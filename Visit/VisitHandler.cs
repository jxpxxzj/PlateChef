using SuperSocket.WebSocket.Server;

namespace PlateChef.Visit
{
    public class VisitHandler: BaseHandler
    {
        public override bool Enabled { get => base.Enabled; 
           set
           {
                base.Enabled = value;
                if (!value)
                {
                    this.clear();
                }
            }
        }

        private List<string> allNames = new List<string>();
        private Dictionary<string, int> nameOrder = new Dictionary<string, int>();
        private Dictionary<string, bool> treatDict = new Dictionary<string, bool>();
        private Dictionary<string, bool> trickDict = new Dictionary<string, bool>();

        private Queue<string> queueNames = new Queue<string>();
        private List<string> visitingNames = new List<string>();
        private List<string> finishedNames = new List<string>();

        public int TotalCustomerCount
        {
            get
            {
                return allNames.Count;
            }
        }

        public int QueueUsersCount
        {
            get
            {
                return queueNames.Count;
            }
        }

        public int VisitingCustomerCount
        {
            get
            {
                return visitingNames.Count;
            }
        }

        public int FinishCustomerCount
        {
            get
            {
                return finishedNames.Count;
            }
        }

        public string NextCustomerName
        {
            get
            {
                var success = queueNames.TryPeek(out var name);
                if (success)
                {
                    return name;
                }

                return "";
            }
        }

        public string[] AllNames
        {
            get
            {
                return this.allNames.ToArray();
            }
        }

        public string[] QueueNames
        {
            get
            {
                return this.queueNames.ToArray();
            }
        }

        public string[] FinishedNames
        {
            get
            {
                return this.finishedNames.ToArray();
            }
        }

        public string[] VisitingNames
        {
            get
            {
                return this.visitingNames.ToArray();
            }
        }

        public void SetOrderingEnable(bool enable)
        {
            if (!this.Enabled)
            {
                return;
            }

            var message = new PlateMessage()
            {
                IsIntegration = true
            };

            message.Type = enable ? PlateMessageType.VisitOrderingEnable : PlateMessageType.VisitOrderingDisable;

            sendMessage(message);
        }

        public int GetOrder(string name)
        {
            if (this.nameOrder.ContainsKey(name))
            {
                return this.nameOrder[name];
            }

            return 0;
        }

        public string[] GetBatchNextCustomer(int count)
        {
            return this.QueueNames.Take(count).ToArray();
        }

        public void sendNameRequest()
        {
            var success = queueNames.TryDequeue(out var name);
            if (success)
            {
                var message = new PlateMessage()
                {
                    Type = PlateMessageType.VisitAddName,
                    IsIntegration = true
                };

                var payload = new VisitDetails() { Name = name };
                message.Data = payload.ToString();
                sendMessage(message);
                this.visitingNames.Add(name);
            }
        }

        private void clearCustomer(string name)
        {
            if (!this.finishedNames.Contains(name))
            {
                this.finishedNames.Add(name);
            }

            this.visitingNames.Remove(name);
        }

        private void doneDay()
        {
            this.finishedNames.Clear();
            this.queueNames.Clear();
            this.visitingNames.Clear();
        }

        private void clear()
        {
            this.doneDay();
            this.allNames.Clear();
            this.nameOrder.Clear();
            this.treatDict.Clear();
            this.trickDict.Clear();
        }

        private void sendNameOrder(string name)
        {
            if (this.nameOrder.ContainsKey(name) || this.trickDict.ContainsKey(name) || this.treatDict.ContainsKey(name))
            {
                var message = new PlateMessage()
                {
                    Type = PlateMessageType.VisitDetails,
                    IsIntegration = true
                };

                var trick = this.trickDict.ContainsKey(name);
                var treat = this.treatDict.ContainsKey(name);
   
                var payload = new VisitDetails() { Name = name,IsTreat = treat, IsTrick = trick }; // TODO: bits not supported
                if (this.nameOrder.ContainsKey(name))
                {
                    payload.Order = this.nameOrder[name];
                }

                message.Data = payload.ToString();

                sendMessage(message);
            }
        }

        public void ShuffleQueue()
        {
            var random = new Random();
            var newList = new List<string>(this.allNames).OrderBy(s => Guid.NewGuid().ToString());
            queueNames.Clear();

            foreach (var item in newList)
            {
                queueNames.Enqueue(item);
            }
        }

        private void shuffle()
        {
            this.doneDay();
            this.ShuffleQueue();
        }

        public void AddName(string name)
        {
            if (!this.finishedNames.Contains(name) && !this.queueNames.Contains(name) && !this.visitingNames.Contains(name))
            {
                this.queueNames.Enqueue(name);
            }

            if (this.allNames.Contains(name))
            {
                return;
            }

            this.allNames.Add(name);
        }
        public void RemoveName(string name)
        {
            this.allNames.Remove(name);
            this.queueNames = new Queue<string>(this.queueNames.Where(t => t != name));
            this.treatDict.Remove(name);
            this.trickDict.Remove(name);
        }

        public override void HandleComment(string username, string content)
        {
            if (!this.Enabled)
            {
                return;
            }

            var commandArr = content.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (commandArr.Length == 1) // !visit or !orderX or !leave
            { 
                if (commandArr[0] == "!visit")
                {
                    this.AddName(username);
                    this.trickDict.Remove(username);
                    this.treatDict.Remove(username);
                }

                if (commandArr[0] == "!leave")
                {
                    this.RemoveName(username);
                }

                if (!commandArr[0].StartsWith("!order"))
                {
                    var orderIndex = commandArr[0].Last().ToString();

                    var success = int.TryParse(orderIndex, out var idx);
                    if (success && idx >= 1 && idx <= 3)
                    {
                        this.nameOrder.Add(username, idx);
                    }
                    if (success && idx == 0)
                    {
                        this.nameOrder.Remove(username);
                    }
                }
            } else if (commandArr.Length == 2) // !order X
            {
                if (commandArr[0] == "!order")
                {
                    this.AddName(username);

                    var success = int.TryParse(commandArr[1], out var idx);
                    if (success && idx >=1 && idx <= 3)
                    {
                        this.nameOrder.Add(username, idx);
                    }
                    if (success && idx == 0)
                    {
                        this.nameOrder.Remove(username);
                    }
                }

                if (commandArr[0] == "!visit") // !visit trick or !visit treat
                {
                    this.AddName(username);
                    var orderIndex = commandArr[1];

                    if (orderIndex == "trick")
                    {
                        this.trickDict[username] = true;
                        this.treatDict.Remove(username);
                    }
                    else if (orderIndex == "treat")
                    {
                        this.trickDict.Remove(username);
                        this.treatDict[username] = true;
                    }
                }
            }
        }

        public override void HandleCommand(PlateMessage message)
        {
            if (!this.Enabled)
            {
                return;
            }

            if (message.Type != PlateMessageType.Visit)
            {
                return;
            }

            var req = new ChefNamedRequest(message.RawString);

            if (req.Instruction == ChefNamedRequestType.Request)
            {
                sendNameRequest();
            }

            if (req.Instruction == ChefNamedRequestType.ClearCustomer)
            {
                clearCustomer(req.Name);
            }

            if (req.Instruction == ChefNamedRequestType.Details)
            {
                sendNameOrder(req.Name);
            }

            if (req.Instruction == ChefNamedRequestType.Clear)
            {
                clear();
            }

            if (req.Instruction == ChefNamedRequestType.Shuffle)
            {
                shuffle();
            }
        }
    }
}

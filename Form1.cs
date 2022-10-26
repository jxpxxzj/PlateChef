using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using SuperSocket.WebSocket;
using SuperSocket.WebSocket.Server;
using Newtonsoft.Json;
using System.Diagnostics;
using PlateChef.Danmaku;
using PlateChef.Visit;

namespace PlateChef
{
    public partial class Form1 : Form
    {
        private IHost host;
        private WebSocketSession session;
        private bool closing;

        private PlateDict dict;

        // game status
        public int day;
        public int money;
        public int level;

        public int nolosing;
        public int patience;
        public int instant;
        public int nobad;
        public int process;

        public bool syncingStatus = false;

        public DanmakuLoader danmakuLoader = new DanmakuLoader();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            host = WebSocketHostBuilder.Create()
                .UseWebSocketMessageHandler(handleSession)
                .ConfigureAppConfiguration((hostCtx, configApp) =>
                {
                    configApp.AddInMemoryCollection(new Dictionary<string, string>
                    {
                        { "serverOptions:name", "TestServer" },
                        { "serverOptions:listeners:0:ip", "Any" },
                        { "serverOptions:listeners:0:port", "12392" }
                    });
                })
            .Build();

            host.StartAsync();
        }

        private async ValueTask handleSession(WebSocketSession session, WebSocketPackage package)
        {
            if (this.closing)
            {
                await session.CloseAsync();
                return;
            }

            this.Invoke(() =>
            {
                var data = package.Message;
                if (data[0] != '{') {
                    return;
                }

                var msg = JsonConvert.DeserializeObject<PlateMessage>(package.Message);
                msg.RawString = data;
                this.session = session;
                this.visitHandler.Session = session;
                this.pollHander.Session = session;
                this.handleCommand(msg);
            });
        }

        private void handleCommand(PlateMessage message) 
        {
            this.label1.Text = "connected";
            this.label2.Text = message.Type;

            if (!message.IsDebugMessage)
            {
                Debug.WriteLine(message.RawString);
            }
            
            if (message.Type == PlateMessageType.GameData)
            {
                this.dict = new PlateDict(message.RawString)!;
                
                // blueprint
                foreach (var elem in dict.Appliances)
                {
                    comboBox1.Items.Add(elem);
                }

                comboBox1.SelectedIndex = 0;

                // card
                foreach (var elem in dict.Cards)
                {
                    comboBox2.Items.Add(elem);
                }

                comboBox2.SelectedIndex = 0;
            }

            // game status
            if (message.Type == PlateMessageType.Money)
            {
                this.money = message.Value;
            }

            if (message.Type == PlateMessageType.Day)
            {
                this.day = message.Value;
            }

            if (message.Type == PlateMessageType.Level)
            {
                this.level = message.Value;
            }


            // cheat
            if (message.Type == PlateMessageType.CheatInstanceProcesses)
            {
                this.instant = message.Value;
            }

            if (message.Type == PlateMessageType.CheatNoBadProcesses)
            {
                this.nobad = message.Value;
            }

            if (message.Type == PlateMessageType.CheatNoPatience)
            {
                this.patience = message.Value;
            }

            if (message.Type == PlateMessageType.CheatNoProcesses)
            {
                this.process = message.Value;
            }

            if (message.Type == PlateMessageType.CheatNoLosing)
            {
                this.nolosing = message.Value;
            }

            this.visitHandler.HandleCommand(message);
            this.pollHander.HandleCommand(message);
            
            refreshStatus();
            refreshVisitStatus();
        }

        private void refreshStatus()
        {
            this.label3.Text = $"Day: {this.day} / Money: {this.money} / Level: {this.level}\nNoLosing: {this.nolosing} / NoPatience: {this.patience} / InstantProcess: {this.instant} / NoBadProcess: {this.nobad} / NoProcesses: {this.process}";
            if (syncingStatus)
            {
                this.textBox1.Text = this.money.ToString();
                this.textBox2.Text = this.day.ToString();
                this.textBox4.Text = this.level.ToString();

                this.checkInstanceProcesses.Checked = this.instant == 1;
                this.checkNoBadProcess.Checked = this.nobad == 1;
                this.checkNoLosing.Checked = this.nolosing == 1;
                this.checkNoPatience.Checked = this.patience == 1;
                this.checkNoProcesses.Checked = this.process == 1;
            }
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            await host.StopAsync();
            host.Dispose();
            Application.Exit();
            this.closing = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (session == null)
            {
                return;
            }

            var selected = (PlateDictKV)comboBox1.SelectedItem;

            var data = new PlateMessage()
            {
                Type = PlateMessageType.AddBlueprint,
                Value = selected.ID,
            };

            await session.SendAsync(data.ToString());
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (session == null)
            {
                return;
            }

            var data = new PlateMessage()
            {
                Type = PlateMessageType.RequestData
            };

            await session.SendAsync(data.ToString());
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (session == null)
            {
                return;
            }

            var selected = (PlateDictKV)comboBox2.SelectedItem;

            var data = new PlateMessage()
            {
                Type = PlateMessageType.CreateCard,
                Value = selected.ID,
            };

            await session.SendAsync(data.ToString());
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (session == null)
            {
                return;
            }

            if (syncingStatus)
            {
                return;
            }

            var data = new PlateMessage()
            {
                Type = PlateMessageType.Money,
                Value = int.Parse(textBox1.Text),
            };

            await session.SendAsync(data.ToString());
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            if (session == null)
            {
                return;
            }

            if (syncingStatus)
            {
                return;
            }

            var data = new PlateMessage()
            {
                Type = PlateMessageType.Day,
                Value = int.Parse(textBox2.Text),
            };

            await session.SendAsync(data.ToString());
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            if (session == null)
            {
                return;
            }

            var data = new PlateMessage()
            {
                Type = PlateMessageType.EndDay,
            };

            await session.SendAsync(data.ToString());
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            if (session == null)
            {
                return;
            }

            var data = new PlateMessage()
            {
                Type = PlateMessageType.CreateCustomers,
                Value = int.Parse(textBox3.Text)
            };

            await session.SendAsync(data.ToString());
        }

        private async void button7_Click_1(object sender, EventArgs e)
        {
            if (session == null)
            {
                return;
            }

            var data = new PlateMessage()
            {
                Type = PlateMessageType.RemoveCustomers,
            };

            await session.SendAsync(data.ToString());
            refreshVisitStatus();
        }

        private async void checkNoLosing_CheckedChanged(object sender, EventArgs e)
        {
            if (session == null)
            {
                return;
            }

            if (syncingStatus)
            {
                return;
            }

            var data = new PlateMessage()
            {
                Type = PlateMessageType.CheatNoLosing,
                Value = checkNoLosing.Checked ? 1 : 0
            };

            await session.SendAsync(data.ToString());
        }

        private async void checkNoPatience_CheckedChanged(object sender, EventArgs e)
        {
            if (session == null)
            {
                return;
            }

            if (syncingStatus)
            {
                return;
            }

            var data = new PlateMessage()
            {
                Type = PlateMessageType.CheatNoPatience,
                Value = checkNoPatience.Checked ? 1 : 0
            };

            await session.SendAsync(data.ToString());
        }

        private async void checkInstanceProcesses_CheckedChanged(object sender, EventArgs e)
        {
            if (session == null)
            {
                return;
            }

            if (syncingStatus)
            {
                return;
            }

            var data = new PlateMessage()
            {
                Type = PlateMessageType.CheatInstanceProcesses,
                Value = checkInstanceProcesses.Checked ? 1 : 0
            };

            await session.SendAsync(data.ToString());
        }

        private async void checkNoBadProcess_CheckedChanged(object sender, EventArgs e)
        {
            if (session == null)
            {
                return;
            }

            if (syncingStatus)
            {
                return;
            }

            var data = new PlateMessage()
            {
                Type = PlateMessageType.CheatNoBadProcesses,
                Value = checkNoBadProcess.Checked ? 1 : 0
            };

            await session.SendAsync(data.ToString());
        }

        private async void checkNoProcesses_CheckedChanged(object sender, EventArgs e)
        {
            if (session == null)
            {
                return;
            }

            if (syncingStatus)
            {
                return;
            }

            var data = new PlateMessage()
            {
                Type = PlateMessageType.CheatNoProcesses,
                Value = checkNoProcesses.Checked ? 1 : 0
            };

            await session.SendAsync(data.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            syncingStatus = checkBox1.Checked;
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            if (session == null)
            {
                return;
            }

            if (syncingStatus)
            {
                return;
            }

            var data = new PlateMessage()
            {
                Type = PlateMessageType.Level,
                Value = int.Parse(textBox4.Text),
            };

            await session.SendAsync(data.ToString());
        }

        private async void buttonSendCommand_Click(object sender, EventArgs e)
        {
            if (session == null)
            {
                return;
            }

            await session.SendAsync(textBoxCommand.Text);
            textBoxCommand.Clear();
        }

        private async void buttonConnectRoom_Click(object sender, EventArgs e)
        {
            await danmakuLoader.ConnectAsync(int.Parse(textBoxRoomID.Text));
            textBoxComment.Clear();
            textBoxComment.Text += $"Room {textBoxRoomID.Text} Connected\r\n";

            danmakuLoader.ReceivedDanmaku += (sender, e) =>
            {
                if (e.Danmaku.MsgType == MsgTypeEnum.Comment)
                {
                    Debug.Print($"Comment: {e.Danmaku.UserName}: {e.Danmaku.CommentText}");
                    textBoxComment.Text += $"{e.Danmaku.UserName}: {e.Danmaku.CommentText}\r\n";

                    this.visitHandler.HandleComment(e.Danmaku.UserName, e.Danmaku.CommentText);
                    this.pollHander.HandleComment(e.Danmaku.UserName, e.Danmaku.CommentText);
                }

                if (e.Danmaku.InteractType == InteractTypeEnum.Enter)
                {
                    Debug.Print($"Enter: {e.Danmaku.UserName}");
                    textBoxComment.Text += $"--- {e.Danmaku.UserName} Enter Room ---\r\n";
                }

                refreshVisitStatus();
            };

            danmakuLoader.Disconnected += async (sender, e) =>
            {
                await Task.Delay(5000);
                await danmakuLoader.ConnectAsync(int.Parse(textBoxRoomID.Text));
            };
        }


        // visit

        public VisitHandler visitHandler = new VisitHandler();
        public string lastWriteText = "";
        private void refreshVisitStatus()
        {
            this.listBoxQueueNames.Items.Clear();
            foreach(var name in this.visitHandler.QueueNames)
            {
                var realName = name;
                var order = this.visitHandler.GetOrder(name);
                if (order != 0)
                {
                    realName += $" ({order})";
                }
                this.listBoxQueueNames.Items.Add(realName);
            }

            this.listBoxFinishedNames.Items.Clear();
            this.listBoxFinishedNames.Items.AddRange(this.visitHandler.FinishedNames);

            this.listBoxVisitingNames.Items.Clear();
            foreach (var name in this.visitHandler.VisitingNames)
            {
                var realName = name;
                var order = this.visitHandler.GetOrder(name);
                if (order != 0)
                {
                    realName += $" ({order})";
                }
                this.listBoxVisitingNames.Items.Add(realName);
            }

            this.labelVisitStatus.Text = $"Total: {visitHandler.TotalCustomerCount} Visiting: {visitHandler.VisitingCustomerCount} Finished: {visitHandler.FinishCustomerCount} Next: {visitHandler.NextCustomerName}";

            // dump to file
            /*var fileText = $"总人数：{visitHandler.TotalCustomerCount} 店内人数：{visitHandler.VisitingCustomerCount} 离店人数：{visitHandler.FinishCustomerCount} ";
            if (visitHandler.NextCustomerName == "")
            {
                fileText += $"下一位：无";
            } 
            else
            {
                fileText += $"下一位：{visitHandler.NextCustomerName}";
            }*/
            var fileText = $"顾客队列：{visitHandler.QueueUsersCount}\r\n";
            var queues = visitHandler.GetBatchNextCustomer(5);
            fileText += string.Join("\r\n", queues);

            try
            {
                if (fileText != lastWriteText)
                {
                    File.WriteAllText("./status.txt", fileText);
                    lastWriteText = fileText;
                }
            } catch (Exception e)
            {

            }
        }

        private void checkBoxEnableVisit_CheckedChanged(object sender, EventArgs e)
        {
            this.visitHandler.Enabled = this.checkBoxEnableVisit.Checked;
        }

        private void checkBoxEnableOrder_CheckedChanged(object sender, EventArgs e)
        {
            this.visitHandler.SetOrderingEnable(this.checkBoxEnableOrder.Checked);
        }

        // polls

        public PollHandler pollHander = new PollHandler();

        private void checkBoxEnablePolls_CheckedChanged(object sender, EventArgs e)
        {
            this.pollHander.Enabled = checkBoxEnablePolls.Checked;
        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            this.visitHandler.ShuffleQueue();
            this.refreshVisitStatus();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("./import.txt");
            foreach(var line in lines)
            {
                this.visitHandler.AddName(line);
            }

            this.refreshVisitStatus();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var timeStampStartTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var timestamp = (int)(DateTime.Now - timeStampStartTime).TotalSeconds;

            var users = string.Join(Environment.NewLine, this.visitHandler.AllNames);
            File.WriteAllText($"./{timestamp}.txt", users);
        }
    }
}
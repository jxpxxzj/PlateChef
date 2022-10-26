using SuperSocket.WebSocket.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlateChef.Visit
{
    public class PollHandler : BaseHandler
    {
        private Dictionary<string, int> userVotes = new Dictionary<string, int>();

        public override bool Enabled { get => base.Enabled; 
            set { 
                base.Enabled = value; 
                if (!value)
                {
                    this.userVotes.Clear();
                }
            } 
        }

        public override void HandleCommand(PlateMessage message)
        {
            if (!this.Enabled)
            {
                return;
            }

            if (message.Type == PlateMessageType.Polls)
            {
                // var polls = new PollRequest(message.RawString);
                this.userVotes.Clear();
            }
        }

        public override void HandleComment(string username, string content)
        {
            if (!this.Enabled)
            {
                return;
            }

            var command = content.Split(" ");
            if (command.Length == 2)
            {
                if (command[0] == "!polls" || command[0] == "!poll" || command[0] == "!vote")
                {
                    var success = int.TryParse(command[1], out var pollIndex);
                    if (success && pollIndex >= 1 && pollIndex <= 2)
                    {
                        this.userVotes[username] = pollIndex - 1;
                    }

                    if (success && pollIndex == 0)
                    {
                        this.userVotes.Remove(username);
                    }
                    
                }
            }

            UpdatePoll();
        }

        public void UpdatePoll()
        {
            if (!this.Enabled)
            {
                return;
            }

            var msg = new PlateMessage()
            {
                Type = PlateMessageType.PollUpdate,
                IsIntegration = true
            };

            var vote0 = this.userVotes.Values.Where(t => t == 0).Count();
            var vote1 = this.userVotes.Values.Where(t => t == 1).Count();

            var update = new PollUpdate()
            {
                Choices = new List<int> { vote0, vote1 },
                IsComplete = false, // TODO:
                IsForced = false,
                PollProgress = 0.0f
            };

            msg.Data = update.ToString();

            sendMessage(msg);
        }
    }
}

using SuperSocket.WebSocket.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlateChef.Visit
{
    public abstract class BaseHandler
    {
        public WebSocketSession Session { get; set; }

        private bool enabled;
        public virtual bool Enabled { 
            get {
                return enabled;
            }
            set 
            {
                this.enabled = value;
            } 
        }

        public abstract void HandleComment(string username, string content);

        public abstract void HandleCommand(PlateMessage message);

        protected async void sendMessage(PlateMessage message)
        {
            if (this.Session == null || !this.Enabled)
            {
                return;
            }

            await Session.SendAsync(message.ToString());
        }
    }
}

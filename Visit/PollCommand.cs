using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlateChef.Visit
{
    public class PollUpdate
	{
		public int Index { get; set; }
		public List<int> Choices { get; set; }
		public bool IsComplete { get; set; }
		public bool IsForced { get; set; }
		public float PollProgress { get; set; }

		public PollUpdate()
        {

        }

		public PollUpdate(string text)
        {
			var poll = JsonConvert.DeserializeObject<PollUpdate>(text);

			this.Index = poll.Index;
			this.Choices = poll.Choices;
			this.IsComplete = poll.IsComplete;
			this.IsForced = poll.IsForced;
			this.PollProgress = poll.PollProgress;
        }

        public override string ToString()
        {
			return JsonConvert.SerializeObject(this);
        }
    }

	public class PollRequest
    {
		public string Type { get; set; }
		public string Instruction { get; set; }
		public string[] Cards { get; set; }

		public PollRequest()
        {

        }

		public PollRequest(string text)
        {
			var req = JsonConvert.DeserializeObject<PollRequest>(text);
			this.Type = req.Type;
			this.Instruction = req.Instruction;
			this.Cards = req.Cards;
        }
    }
}

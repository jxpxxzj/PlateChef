using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlateChef.Visit
{
	public class VisitDetails
	{
		public string Name { get; set; }

		public int Order { get; set; }
		 
		public int Bits { get; set; }

		public bool IsTrick { get; set; }

		public bool IsTreat { get; set; }

		public VisitDetails()
        {

        }

		public VisitDetails(string text)
        {
			var details = JsonConvert.DeserializeObject<VisitDetails>(text);

			this.Name = details.Name;
			this.Order = details.Order;
			this.Bits = details.Bits;
			this.IsTrick = details.IsTrick;
			this.IsTreat = details.IsTreat;
        }

        public override string ToString()
        {
			return JsonConvert.SerializeObject(this);
        }
    }

	public static class ChefNamedRequestType
    {
		public static string ClearCustomer { get; } = "clear_customer";
		public static string Request { get; } = "request";
		public static string Details { get; } = "details";
		public static string Clear { get; } = "clear";
		public static string Shuffle { get; } = "shuffle";
    }

	public class ChefNamedRequest
	{
		public string Type { get; set; }

		public string Instruction { get; set; }

		public string Name { get; set; }

		public ChefNamedRequest()
        {

        }

		public ChefNamedRequest(string text)
        {
			var req = JsonConvert.DeserializeObject<ChefNamedRequest>(text);
			this.Type = req.Type;
			this.Instruction = req.Instruction;
			this.Name = req.Name;
        }
	}

}

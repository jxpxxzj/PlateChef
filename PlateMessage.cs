using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlateChef
{
	public static class PlateMessageType
    {
		public static string RequestData { get; } = "REQUEST_DATA";
		public static string RemoveCustomers { get; } = "REMOVE_CUSTOMERS";
		public static string CreateCustomers { get; } = "CREATE_CUSTOMERS";
		public static string CreateCard { get; } = "CREATE_CARD";
		public static string AddBlueprint { get; } = "ADD_BLUEPRINT";
		public static string CreateAppliance { get; } = "CREATE_APPLIANCE";
		public static string SetUiVisibility { get; } = "SET_UI_VISIBILITY";
		public static string EndDay { get; } = "END_DAY";
		public static string AddCrate { get; } = "ADD_CRATE";

		// Resp
		public static string GameData { get; } = "GAME_DATA";

		// Control
		public static string Day { get; } = "DAY";
		public static string Level { get; } = "LEVEL";
		public static string Money { get; } = "MONEY";

		// Cheat
		public static string CheatNoLosing { get; } = "CHEAT_NO_LOSING";
		public static string CheatNoPatience { get; } = "CHEAT_NO_PATIENCE";
		public static string CheatInstanceProcesses { get; } = "CHEAT_INSTANT_PROCESSES";
		public static string CheatNoBadProcesses { get; } = "CHEAT_NO_BAD_PROCESSES";
		public static string CheatNoProcesses { get; } = "CHEAT_NO_PROCESSES";

		// visit
		public static string Visit { get; } = "VISIT";
		public static string VisitAddName { get; } = "VISIT_ADD_NAME";
		public static string VisitDetails { get; } = "VISIT_DETAILS";
		public static string VisitOrderingEnable { get; } = "VISIT_ORDERING_ENABLE";
		public static string VisitOrderingDisable { get; } = "VISIT_ORDERING_DISABLE";

		// poll
		public static string Polls { get; } = "POLLS";
		public static string PollUpdate { get; } = "POLL_UPDATE";
	}

    public class PlateMessage
    {
		public string Type { get; set; }

		public int Value { get; set; }

		public bool IsIntegration { get; set; }

		public string Data { get; set; }

		public string RawString { get; set; }

        public override string ToString()
        {
			return JsonConvert.SerializeObject(this);
        }

		public bool IsDebugMessage
        {
			get
            {
				if (this.Type.StartsWith("CHEAT") || this.Type == PlateMessageType.Day || this.Type == PlateMessageType.Level || this.Type == PlateMessageType.Money)
                {
					return true;
                }

				return false;
            }
        }

		public bool IsVisitMessage
        {
			get
            {
				return this.Type.StartsWith("VISIT");
            }
        }
    }
}

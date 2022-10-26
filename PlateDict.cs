using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PlateChef
{
    public class PlateDictKV
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"[{ID}] {Name}";
        }

        public static int Compare(PlateDictKV a, PlateDictKV b)
        {
            if (a.Name == b.Name)
            {
                return a.ID > b.ID ? -1 : 1;
            }

            if (a.Name == "" && b.Name != "")
            {
                return 1;
            }

            if (a.Name != "" && b.Name == "")
            {
                return -1;
            }

            return string.Compare(a.Name, b.Name);
        }
    }
    public class PlateDict
    {
        public string Type { get; set; }
        public List<PlateDictKV> Appliances { get; set; }
        public List<PlateDictKV> Cards { get; set; }

        public PlateDict()
        {

        }

        public PlateDict(string text)
        {
            var dict = JsonConvert.DeserializeObject<PlateDict>(text);
            dict.Appliances.Sort((a, b) => PlateDictKV.Compare(a, b));
            dict.Cards.Sort((a, b) => PlateDictKV.Compare(a, b));

            this.Type = dict.Type;
            this.Appliances = dict.Appliances;
            this.Cards = dict.Cards;
        }
    }
}

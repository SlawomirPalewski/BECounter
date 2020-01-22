using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECounterNew
{
    public class ChampionCollection
    {
        public List<ChampionData> championList { get; set; }
    }

    public class ChampionData
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public int price { get; set; }
    }
}

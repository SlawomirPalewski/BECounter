using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECounter
{
    public class ChampionCollection
    {
        public List<ChampionData> championList { get; set; }
    }

    public class ChampionData
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
    }
}

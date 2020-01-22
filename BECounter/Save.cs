using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECounterNew
{
    public class Save
    {
        public int currentBE { get; set; }
        public List<SavedChampion> champion { get; set; }
    }
    public class SavedChampion
    {
        public string name { get; set; }
        public int quantity { get; set; }
    }
}

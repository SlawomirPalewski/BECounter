using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECounterNew
{
    public class Save
    {
        public int CurrentBE { get; set; }
        public List<SavedChampion> Champion { get; set; }
    }
    public class SavedChampion
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECounterNew
{
    public class ChampionValueChangeArgs : EventArgs
    {
        private int _id;
        private int _value;

        public int Id
        {
            get { return _id; }
        }

        public int Value
        {
            get { return _value; }
        }

        public ChampionValueChangeArgs(int id, int value) : base()
        {
            _id = id;
            _value = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butorok
{
    public enum Anyagok {fém,fa,műanyag }
    class Butor
    {
        public int Suly { get; set; }
        public Anyagok Anyag { get; set; }
        public int MaxMagassag { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butorok
{
    public enum Alakok { kör,négyzet,háromszög,ellipszis}
    class Asztal:Butor
    {
        public Alakok Alak { get; set; }
        public bool Fiokos { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class ToplistaElem
    {
        public string Nev { get; set; }
        public int Pontszam { get; set; }

        public ToplistaElem(string nev, int pontszam)
        {
            Nev = nev;
            Pontszam = pontszam;
        }

        


    }
}

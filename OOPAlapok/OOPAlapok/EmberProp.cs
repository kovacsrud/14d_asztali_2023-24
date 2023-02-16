using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    class EmberProp
    {
     

        //Property: olyan struktúra, amely magában foglalja
        //a változót, valamint a hozzá tartozó lekérdező és
        //beállító függvényeket 3in1 
        public string Nev { get; set; }
        public string SzuletesiHely { get; set; }
        public int Magassag { get; set; }
        public int Suly { get; set; }

        public EmberProp(string nev, string szuletesiHely, int magassag, int suly)
        {
            Nev = nev;
            SzuletesiHely = szuletesiHely;
            Magassag = magassag;
            Suly = suly;
        }

        public EmberProp()
        {

        }

    }
}

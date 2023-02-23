using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ember
{
    //Azt absztrakt osztály csupán örökítési célokat szolgál
    abstract class Ember
    {
        public string Nev { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }
        public int Szulev { get; set; }

        //Lesznek olyan metódusok : Eszik, Alszik, Mozog

        public abstract void Eszik();

        public abstract void Alszik();

        public abstract void Mozog();

        public int Eletkor()
        {
            return DateTime.Now.Year - Szulev;
        }

        public override string ToString()
        {
            return $"{Nev},{Suly},{Magassag},{Szulev}";
        }
    }
}

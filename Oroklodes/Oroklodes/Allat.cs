using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    class Allat
    {
        
        public int Suly { get; set; }
        public int Magassag { get; set; }

        public Allat(int suly, int magassag)
        {
            Suly = suly;
            Magassag = magassag;
            Console.WriteLine("Ős osztály konstruktor");
        }

        public virtual void Eszik()
        {
            Console.WriteLine("Az állat eszik");
        }

        public virtual void Iszik()
        {
            Console.WriteLine("Az állat iszik");
        }

        public virtual void Mozog()
        {
            Console.WriteLine("Az állat mozog");
        }

        public override string ToString()
        {
            return $"Súly:{Suly},Magasság:{Magassag}";
        }

    }
}

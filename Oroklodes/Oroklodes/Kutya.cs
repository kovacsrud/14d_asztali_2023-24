using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    class Kutya:Allat
    {
        public String Fajta { get; set; }

        public Kutya(string fajta,int suly,int magassag):base(suly,magassag)
        {
            Fajta = fajta;
            Console.WriteLine("Kutya osztály konstruktor");
        }

        public override void Mozog()
        {
            Console.WriteLine("A kutya gyorsan mozog.");
        }

        public override void Eszik()
        {
            Console.WriteLine("A kutya habzsolva eszik.");
        }

        public override void Iszik()
        {
            Console.WriteLine("A kutya lefetyelve iszik.");
        }

        public override string ToString()
        {
            return base.ToString()+"Fajta:"+Fajta;
        }
    }
}

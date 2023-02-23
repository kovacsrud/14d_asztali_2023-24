using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ember
{
    class Sportolo:Ember
    {
        public Sportolo(string sportag,string nev, int suly,int magassag,int szulev)
        {
            Sportag = sportag;
            Nev = nev;
            Suly = suly;
            Magassag = magassag;
            Szulev = szulev;
            
                

        }

        public string Sportag { get; set; }

        public override void Alszik()
        {
            Console.WriteLine("A sportoló sokat alszik.");
        }

        public override void Eszik()
        {
            Console.WriteLine("A sportoló idafigyel arra, hogy mit eszik.");
        }

        public override void Mozog()
        {
            Console.WriteLine("A sportoló gyorsan mozog.");
        }

        public void Sportol()
        {
            Console.WriteLine($"A sportoló {Sportag} sportágban sportol.");
        }

        public override string ToString()
        {
            return base.ToString()+" Sportág:"+Sportag;
        }
    }
}

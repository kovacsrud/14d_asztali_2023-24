using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    class Macska:Allat
    {
       

        public string Fajta { get; set; }
        public bool HosszuSzoru { get; set; }

        public Macska(string fajta, bool hosszuSzoru,int suly,int magassag):base(suly,magassag)
        {
            Fajta = fajta;
            HosszuSzoru = hosszuSzoru;
        }

        public override string ToString()
        {
            return base.ToString()+",Fajta:"+Fajta+" Hosszúszőrű?"+HosszuSzoru;
        }

        public override void Mozog()
        {
            Console.WriteLine("A macska lopakodik");
        }

        public override void Eszik()
        {
            Console.WriteLine("A macska nem habzsol");
        }
    }
}

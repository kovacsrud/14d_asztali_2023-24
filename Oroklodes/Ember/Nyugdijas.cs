using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ember
{
    class Nyugdijas:Ember
    {
        public Nyugdijas(string nev,int suly,int magassag,int szulev,string miVoltASzakmaja)
        {
            MiVoltASzakmaja = miVoltASzakmaja;
            Nev = nev;
            Suly = suly;
            Magassag = magassag;
            Szulev = szulev;
        }

        public string MiVoltASzakmaja { get; set; }

        public override void Alszik()
        {
            Console.WriteLine("A nyugdíjas keveset alszik");
        }

        public override void Eszik()
        {
            Console.WriteLine("A nyugdíjas általában keveset eszik");
        }

        public override void Mozog()
        {
            Console.WriteLine("A nyugdíjas lassabban mozog");
        }
        
        public override string ToString()
        {
            return base.ToString()+" Szakmája a nyugdíj előtt:"+MiVoltASzakmaja;
        }
    }
}

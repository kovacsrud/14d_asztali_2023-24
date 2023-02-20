using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butorok
{
    class Program
    {
        static void Main(string[] args)
        {
            Asztal asztal = new Asztal
            {
                Alak = Alakok.kör,
                Anyag = Anyagok.fa,
                Fiokos = false,
                MaxMagassag = 110,
                Suly = 12
            };

            Szekreny szekreny = new Szekreny
            {
                Anyag = Anyagok.fém,
                Kulcsos = true,
                MaxMagassag = 200,
                Suly = 50,
                Uveges = false

            };

            Console.ReadKey();
        }
    }
}

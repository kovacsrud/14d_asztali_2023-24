using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veletlenszamok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Véletlenszám generátor inicializálása
            Random rand = new Random();


            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(rand.Next(1,5+1));
                //0.0 és 1.0 közötti double típusú érték
                Console.WriteLine(rand.NextDouble());
            }

            //Kérjen be egy értéket konzolról, ennyi véletlenszámot
            //kell majd generálni.
            //Kérjen be egy másik értéket, tárolja el egy változóban
            //Írjon ciklust, amely annyiszor fut le, amekkora
            //értéket az első változónál megadtak. A ciklus generáljon
            //tetszőleges határok közötti véletlen számokat.
            //Számolja meg, hogy hány érték van, amelyik a másodjára
            //bekért értéknél nagyobb
            

            Console.ReadKey();
        }
    }
}

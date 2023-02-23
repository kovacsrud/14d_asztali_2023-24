using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikIdomok
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<ISikidom> sikidomok = new List<ISikidom>();

            for (int i = 0; i < 10; i++)
            {
                sikidomok.Add(new Kor(rand.Next(1, 50 + 1)));
                sikidomok.Add(new Teglalap(rand.Next(1, 50 + 1), rand.Next(1, 100 + 1)));
            }

            

            Console.WriteLine($"Összes kerület:{sikidomok.Sum(x=>x.Kerulet())}");
            Console.WriteLine($"Összes terület:{sikidomok.Sum(x=>x.Terulet())}");

            Console.WriteLine($"Átlagos kerület:{sikidomok.Average(x=>x.Kerulet())}");

            //Mennyi a körök összterülete?
            var korok = sikidomok.FindAll(x => x.GetType() == typeof(Kor)).Sum(x=>x.Kerulet());
            Console.WriteLine($"Körök összkerülete:{korok}");

            //Téglalapok átlagos területe
            var teglalapokTerulete = sikidomok.FindAll(x => x.GetType() == typeof(Teglalap)).Average(x=>x.Terulet());
            Console.WriteLine($"Téglalapok átlagos területe:{teglalapokTerulete}");

            foreach (var i in sikidomok)
            {
                if (i.GetType()==typeof(Kor))
                {
                    Kor kor = (Kor)i;
                    Console.WriteLine($"Sugár:{kor.Sugar},{i.Kerulet()}");
                }
                if (i.GetType()==typeof(Teglalap))
                {
                    Teglalap teglalap = i as Teglalap;
                    Console.WriteLine($"A:{teglalap.A},B:{teglalap.B}");
                }
            }


            Console.ReadKey();
        }
    }
}

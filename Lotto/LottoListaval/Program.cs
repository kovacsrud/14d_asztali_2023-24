using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoListaval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hány számot húzunk?");
            int hanySzam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hány számból sorsolunk?");
            int osszSzam = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            List<int> tippek = new List<int>();
            List<int> huzoSzamok = new List<int>();
            List<int> nyeroSzamok = new List<int>();

            int talalatok = 0;
            HuzoSzamInit(osszSzam, huzoSzamok);
            //Listazas(huzoSzamok);

            for (int i = 0; i < hanySzam; i++)
            {
                Console.Write($"{i + 1}.tipp:");
                int temp = Convert.ToInt32(Console.ReadLine());
                while (temp < 1 || temp > osszSzam || tippek.Contains(temp))
                {
                    Console.Write($"Hibás tipp!, újra{i + 1}.tipp:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                
                tippek.Add(temp);
            }

            tippek.Sort();
            Listazas(tippek);

            //sorsolas
            for (int i = 0; i < hanySzam; i++)
            {
                int nyeroSzamPozicio = rand.Next(0, huzoSzamok.Count);
                int nyeroSzam = huzoSzamok[nyeroSzamPozicio];
                huzoSzamok.RemoveAt(nyeroSzamPozicio);
                nyeroSzamok.Add(nyeroSzam);                
            }

            nyeroSzamok.Sort();
            Listazas(nyeroSzamok);

            for (int i = 0; i < tippek.Count; i++)
            {
                if (nyeroSzamok.Contains(tippek[i]))
                {
                    talalatok++;
                }
            }

            Console.WriteLine($"Találatok száma:{talalatok}");

            Console.ReadKey();
        }

        private static void Listazas(List<int> lista)
        {
            foreach (var i in lista)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private static void HuzoSzamInit(int osszSzam, List<int> huzoSzamok)
        {
            for (int i = 0; i < osszSzam; i++)
            {
                huzoSzamok.Add(i + 1);
            }
        }
    }
}

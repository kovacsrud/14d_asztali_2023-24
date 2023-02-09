using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lottó játék
            //Tippelés->Sorsolás->Eredmény meghatározása
            //Tömbökben tároljuk a szükséges adatokat

            //Bekérjük, hogy mennyi számot húzunk, valamint azt, hogy mennyiből húzzuk

            do
            {

            
            Console.Write("Hány számot húzunk?");
            int hanySzam = Convert.ToInt32(Console.ReadLine());

            Console.Write("Hány számból sorsolunk?");
            int osszSzam = Convert.ToInt32(Console.ReadLine());

            int[] tippek = new int[hanySzam];
            int[] nyeroSzamok = new int[hanySzam];
            Random rand = new Random();
            

            int talalatok = 0;

            //Tippelés, nem lehet két egyforma tipp, a tippnek adott határok között kell lennie.
            for (int i = 0; i < hanySzam; i++)
            {
                Console.Write($"{i + 1}.tipp:");
                int temp = Convert.ToInt32(Console.ReadLine());
                while (temp < 1 || temp > osszSzam || tippek.Contains(temp))
                {
                    Console.Write($"Hibás tipp!, újra{i + 1}.tipp:");
                    temp = Convert.ToInt32(Console.ReadLine());
                }
                tippek[i] = temp;
            }
            Array.Sort(tippek);
            TombLista(tippek);

            //Sorsolás
            for (int i = 0; i < hanySzam; i++)
            {
                int temp = rand.Next(1, osszSzam + 1);
                while (nyeroSzamok.Contains(temp))
                {
                    temp = rand.Next(1, osszSzam + 1);
                }
                nyeroSzamok[i] = temp;
            }
            Array.Sort(nyeroSzamok);
            TombLista(nyeroSzamok);

            //találatok számának megállapítása
            //for (int i = 0; i < tippek.Length; i++)
            //{
            //    for (int j = 0; j < nyeroSzamok.Length; j++)
            //    {
            //        if (tippek[i]==nyeroSzamok[j])
            //        {
            //            talalatok++;
            //        }
            //    }
            //}

            for (int i = 0; i < tippek.Length; i++)
            {
                if (nyeroSzamok.Contains(tippek[i]))
                {
                    talalatok++;
                }
            }

            Console.WriteLine($"Találat:{talalatok}");
            Console.Write("Akar még játszani?(i/n)");


          } while (Console.ReadKey().KeyChar=='i');



            Console.ReadKey();
        }

        private static void TombLista(int[] szamok)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

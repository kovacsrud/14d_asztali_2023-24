using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoOOP
{
    class LottoJatek
    {
        Random rand;
        private List<int> tippek;
        private List<int> huzoSzamok;
        private List<int> nyeroSzamok;
        private int talalatok;
        private int hanySzam;
        private int osszSzam;

        public LottoJatek()
        {
            rand = new Random();
            tippek = new List<int>();
            huzoSzamok = new List<int>();
            nyeroSzamok = new List<int>();
            talalatok = 0;
            hanySzam = 0;
            osszSzam = 0;
            //Jatek();
        }

        public void Jatek()
        {
            
            //HuzoSzamInit();
            do
            {
                SzamBekeres();
                HuzoSzamInit();
                Tippeles();
                Sorsolas();
                TalalatSzamlalas();
                
                tippek.Clear();
                //huzoSzamok.AddRange(nyeroSzamok);
                nyeroSzamok.Clear();
                huzoSzamok.Clear();


                Console.Write("Új játék?(i/n)");
            } while (Console.ReadKey().KeyChar == 'i');

        }

        private void SzamBekeres()
        {
            Console.Write("Hány számot húzunk?");
            hanySzam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hány számból sorsolunk?");
            osszSzam = Convert.ToInt32(Console.ReadLine());
        }

        private void HuzoSzamInit()
        {
            for (int i = 0; i < osszSzam; i++)
            {
                huzoSzamok.Add(i + 1);
            }
        }

        private void Tippeles()
        {
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
        }

        private void Sorsolas()
        {
            for (int i = 0; i < hanySzam; i++)
            {
                int nyeroSzamPozicio = rand.Next(0, huzoSzamok.Count);
                int nyeroSzam = huzoSzamok[nyeroSzamPozicio];
                huzoSzamok.RemoveAt(nyeroSzamPozicio);
                nyeroSzamok.Add(nyeroSzam);
            }

            nyeroSzamok.Sort();
            Listazas(nyeroSzamok);
        }

        private void TalalatSzamlalas()
        {
            for (int i = 0; i < tippek.Count; i++)
            {
                if (nyeroSzamok.Contains(tippek[i]))
                {
                    talalatok++;
                }
            }
            Console.WriteLine($"Találatok száma:{talalatok}");             
        }

        private void Listazas(List<int> lista)
        {
            foreach (var i in lista)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }
}

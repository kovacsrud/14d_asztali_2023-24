using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElemiAlgoritmusok
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            //Elemi algoritmusok
            int[] szamok = new int[100];

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(-200,200+1);
            }

            //Megszámlálás
            int negativok = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]<0)
                {
                    negativok++;
                }
            }

            Console.WriteLine($"Negatív elemek száma:{negativok},Pozitívok:{szamok.Length-negativok}");

            //Összegzés
            int osszeg = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];
            }

            Console.WriteLine($"Összeg:{osszeg}");

            //Minimum és maximum kiválasztás
            int min = szamok[0];
            int max = szamok[0];

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]<min)
                {
                    min = szamok[i];
                }
                if (szamok[i]>max)
                {
                    max = szamok[i];
                }
            }

            Console.WriteLine($"Min:{min},Max:{max}");

            Console.ReadKey();
        }
    }
}

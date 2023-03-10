using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombErtekadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            Random rand = new Random();

            szamok[0] = 112;

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = i;
                //Console.WriteLine(i);
            }

            //for (int i = 0; i < szamok.Length; i++)
            //{
            //    szamok[i] = rand.Next(1, 100 + 1);
            //}

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i]+" ");
            }

            int[] szamok2 = {100,211,456,22,3,78,99,1144 };
            szamok2[0] = 100;

            Console.WriteLine($"Szamok:{szamok[0]},szamok2:{szamok2[0]}");

            int a = 10;
            int b = a;

            b += 10;
            Console.WriteLine($"A:{a}");


            Console.ReadKey();
        }
    }
}

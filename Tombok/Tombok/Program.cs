using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tömb:azonos típusú adatokat tároló adatszerkezet. Deklaráláskor
            //meg kell adni az elemek számát.
            Random rand = new Random();

            int[] szamok = new int[5];
            int[] szamok2 = { 12, 36, 778, 39, 13, 31 };


            //Indexelés: a tömb elemeire a sorszámukkal (index) lehet hivatkozni.
            Console.WriteLine(szamok[1]);
            Console.WriteLine(szamok[4]);
            Console.WriteLine(szamok2[2]);
            szamok2[2] = 399;
            Console.WriteLine(szamok2[2]);

            //Tömb feldolgozása:ciklus
            for (int i = 0; i < szamok2.Length; i++)
            {
                Console.Write(szamok2[i]+" ");
            }
            Console.WriteLine();

            //Foreach ciklus, ebben a ciklusban nem lehet a tömb elemeit módosítani!
            //A tömb elemeit módosítani csak a for ciklusban lehet.
            foreach (var i in szamok2)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(10, 100 + 1);
                Console.WriteLine(szamok[i]);
            }

            Console.ReadKey();
        }
    }
}

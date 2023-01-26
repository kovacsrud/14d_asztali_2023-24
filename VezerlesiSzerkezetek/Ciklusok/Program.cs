using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ciklusok 
            //Elöltesztelő, hátultesztelő, növekményes
            //while, do while, for (foreach)

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine();
            for (int i = 10; i >= 0; i--)
            {
                Console.Write(i + " ");
            }

            //Elöltesztelő
            int szam = 0;
            while (szam<=10)
            {
                Console.WriteLine(szam);
                //szam = szam + 1;
                //szam += 1;
                szam++;

            }

            Console.WriteLine("Hátultesztelő");
            szam = 0;
            do
            {
                Console.WriteLine(szam);
                szam++;

            } while (szam<10);

            //Kérjen be egy egész számot a billentyűzetről!
            //Amennyiben a szám 100-nál nagyobb, akkor
            //ne fogadja el, adjon hibaüzenetet és kérje
            //be újra!

            int inSzam = Convert.ToInt32(Console.ReadLine());
            while (inSzam>100)
            {
                Console.Write("Hibás, újra!:");
                inSzam = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}

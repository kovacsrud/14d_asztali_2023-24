using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazasok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elágazások
            //Egyszeres, többszörös

            int szam = 0;

            if (szam>-1)
            {
                //kódblokk, a blokkon belül létrehozott 
                //változók lokális változók, csak ebben a blokkban
                //léteznek
                Console.WriteLine("A szám pozitív");
            }
            

            if (szam>0)
            {
                Console.WriteLine("A szám pozitív");

            } else if (szam==0)
            {
                Console.WriteLine("A szám nulla");
            } else
            {
                Console.WriteLine("A szám negatív");
            }

            Console.Write("Adj meg egy betűt");
            char betu = Console.ReadKey().KeyChar;

            switch (betu)
            {
                case 'a':
                    Console.WriteLine('a');
                    break;
                case 'b':
                    Console.WriteLine('b');
                    break;
                case 'c':
                    Console.WriteLine('c');
                    break;
                default:
                    Console.WriteLine("Nem ismerem ezt a betűt");
                    break;
            }

            Console.ReadLine();
        }
    }
}

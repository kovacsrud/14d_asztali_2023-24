using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            //Felhasználói input
            Console.Write("Adjon meg egy nevet!");
            string nev = Console.ReadLine();

            Console.WriteLine($"A megadott név:{nev}");

            //Számok bekérése
            int szam1 = 0;
            int szam2 = 0;

            Console.Write("Add meg szam1-et:");
            szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg szam2-t:");
            //szam2 = Convert.ToInt32(Console.ReadLine());
            szam2 = int.Parse(Console.ReadLine());


            Console.WriteLine(szam1-szam2);




            Console.ReadKey();
        }
    }
}

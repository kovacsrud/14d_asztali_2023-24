using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = { 10, 23, 55, 78, 112, 445, 66, 7, 998 };
            string[] szovegek = { "valami", "bármi", "akármi" };
            bool[] logikaiTomb = { false, false, true, true, false };
            double[] tortSzamok = { 4.67, 5.88, 123.6664545 };

            Console.WriteLine(szamok[3]); ;
            Console.WriteLine(szovegek[1]);
            Console.WriteLine(logikaiTomb[0]);
            Console.WriteLine(tortSzamok[2]);

            Console.WriteLine(szamok.Length);
            Console.WriteLine(szovegek.First());
            Console.WriteLine(szovegek.Last());



            Console.ReadKey();
        }
    }
}

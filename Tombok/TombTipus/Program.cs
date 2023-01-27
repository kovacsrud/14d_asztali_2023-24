using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombTipus
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;

            b += 20;

            Console.WriteLine(b);

            int[] szamok = { 10, 20, 30, 40, 50 };
            int[] szamok2 = { 22,33,44,55,66,77};

            szamok2[0] = 20;

            //szamok[0]??
            Console.WriteLine(szamok[0]);

            Console.ReadKey();
        }
    }
}

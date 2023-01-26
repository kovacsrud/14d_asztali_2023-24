using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezerlesiSzerkezetek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a kör sugarát:");
            int sugar = Convert.ToInt32(Console.ReadLine());

            int kerulet = Convert.ToInt32(2 * sugar * Math.PI);
            
            //Típus kényszerítés, kasztolás
            double terulet = (sugar * sugar * Math.PI);


            Console.WriteLine($"Kerülete:{kerulet}, Területe:{terulet:0.00}");

            //Értékadás trükkös dolgai
            int a = 10;
            int b = 0;
            int c = 0;

            b = a++;
            Console.WriteLine(b);

            c = ++a;
            Console.WriteLine(c);


            Console.ReadKey();
        }
    }
}

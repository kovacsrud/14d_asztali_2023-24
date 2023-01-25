using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtozok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asztali alkalmazások.");
            Console.Write("Egy sorba");
            Console.Write(" íródik");
            Console.WriteLine();

            //Egész típusú változók
            //Több ilyen is van, előjeles ill. előjel nélküli, több méret

            int a = 178;
            int b = 56;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a+b);

            Console.WriteLine($"A:{a},B:{b},összeg:{a+b}");

            short c = 34;
            long d = 234234255;

            Console.WriteLine($"8 bites: min:{Byte.MinValue},max:{Byte.MaxValue}");
            Console.WriteLine($"16 bites: min:{Int16.MinValue},max:{Int16.MaxValue}");
            Console.WriteLine($"16 bites: min:{UInt16.MinValue},max:{UInt16.MaxValue}");
            Console.WriteLine($"32 bites: min:{Int32.MinValue},max:{Int32.MaxValue}");
            Console.WriteLine($"32 bites: min:{UInt32.MinValue},max:{UInt32.MaxValue}");
            Console.WriteLine($"64 bites: min:{Int64.MinValue},max:{Int64.MaxValue}");
            Console.WriteLine($"64 bites: min:{UInt64.MinValue},max:{UInt64.MaxValue}");

            //Lebegőpontos számok (nem egész)
            float szam1 = 12.123456789012345678901234567890f;
            double szam2 = 12.123456789012345678901234567890;
            decimal szam3 = 12.123456789012345678901234567890m;

            
            Console.WriteLine($"Float:{szam1}");
            Console.WriteLine($"Double:{szam2}");
            Console.WriteLine($"Decimal:{szam3}");


            //Logikai érték:
            bool logikai = true;
            Console.WriteLine(logikai);
            logikai = !logikai;
            Console.WriteLine(logikai);
            logikai = !logikai;
            Console.WriteLine(logikai);

            //Szöveges változó
            string szoveg = "valami szöveg";

            Console.WriteLine(szoveg);
            //A string típus értéke nem változtatható meg (immutable).
            szoveg = "valami más szöveg";
            Console.WriteLine(szoveg);
            Console.WriteLine(szoveg[3]);

            //Karakteres típus (egyetlen betű)

            char betu = 'a';








            Console.ReadKey();
        }
    }
}

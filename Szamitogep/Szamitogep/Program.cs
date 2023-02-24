using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamitogep
{
    class Program
    {
        static void Main(string[] args)
        {
            Szamitogep gep1 = new Szamitogep();
            Szamitogep gep2 = new Szamitogep(2048,false);

            gep1.Kapcsol();
            Console.WriteLine(gep1.Masolas(800));
            Console.WriteLine(gep1.Masolas(400));
            Console.WriteLine(gep1.ToString());
            Console.WriteLine(gep2.ToString());





            Console.ReadKey();
        }
    }
}

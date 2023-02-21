using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Allat allat = new Allat(3, 10);
            Kutya kutya = new Kutya("vizsla",25,60);
            Macska macska = new Macska("sziámi",false, 2, 20);

            allat.Eszik();
            allat.Iszik();
            allat.Mozog();

            Console.WriteLine(allat.ToString());

            kutya.Mozog();
            kutya.Eszik();
            kutya.Iszik();

            Console.WriteLine(kutya.ToString());
            macska.Eszik();
            macska.Mozog();
            Console.WriteLine(macska.ToString());
            

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmapUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            int szamlalo = 0;

            while (!Console.KeyAvailable)
            {
                using (var bitmap = new Bitmap(1280, 1280))
                {
                    Console.WriteLine(szamlalo);
                    szamlalo++;
                }
                
                
            }


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringek
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string szoveg = "Valami szöveg";
            //Gyakorlatilag tömb, nem lehet megváltoztatni.
            //Tömb: az elemszám kötött.

            for (int i = 0; i < szoveg.Length; i++)
            {
                Console.WriteLine(szoveg[i]);
            }

            szoveg = "Valami szöveg és még szöveg";

            //String műveletek
            //Kisbetűsre alakítás
            Console.WriteLine(szoveg.ToLower());
            
            
            Console.WriteLine(szoveg);
            Console.ReadKey();
        }
    }
}

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

            //for (int i = 0; i < szoveg.Length; i++)
            //{
            //    Console.WriteLine(szoveg[i]);
            //}

            szoveg = "Valami szöveg és még szöveg";

            //String műveletek
            //Kisbetűsre alakítás
            Console.WriteLine(szoveg.ToLower());
            Console.WriteLine(szoveg.ToUpper());

            string sz1 = "Valami";
            string sz2 = "valaMi";

            if (sz1.ToLower()==sz2.ToLower())
            {
                Console.WriteLine("A szövegek megegyeznek");
            } else
            {
                Console.WriteLine("A szövegek nem egyeznek meg!");
            }

            //Kezdete, vége, tartalmazás
            //Kezdet vizsgálata, más string függvényekkel összekapcsolható
            Console.WriteLine(szoveg.ToLower().StartsWith("vala"));
            Console.WriteLine(szoveg.EndsWith("vala"));
            Console.WriteLine(szoveg.ToLower().Contains("vala"));


            //Karakterek levágása a string elejéről, végéről vagy mindkettőről.
            //Trim, TrimStart, TrimEnd
            string masik = "        Valami             ";
            Console.WriteLine(sz1+"-"+masik.Trim()+"-"+sz1);

            string datum = "2012.09.02";

            //Substring - karakterek kiemelése egy stringből

            string ev = datum.Substring(0, 4);
            string honap = datum.Substring(5, 2);
            string nap = datum.Substring(8, 2);

            Console.WriteLine(ev);
            Console.WriteLine(honap);
            Console.WriteLine(nap);

            //String feldarabolása
            string[] datum_elemek = datum.Split('.');

            Console.WriteLine(datum_elemek[0]);

            //String részeinek cseréje, replace

            Console.WriteLine(szoveg.Replace('ö','x'));

            Console.WriteLine(szoveg.Replace("ami", "ima"));
            Console.WriteLine(szoveg.Replace(" ",""));

            

            Console.ReadKey();
        }
    }
}

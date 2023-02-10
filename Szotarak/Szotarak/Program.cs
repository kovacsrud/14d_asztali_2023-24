using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szotarak
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generáljunk 1000db véletlen számot 1-100 között.
            //Számoljuk meg, hogy melyik számból hány db-ot sikerült
            //generálni

            //Szótár adatszerkezet, kulcs-érték párokat tárol

            Random rand = new Random();
            Dictionary<int, int> szamok = new Dictionary<int, int>();

            for (int i = 0; i < 1000; i++)
            {
                int szam = rand.Next(1, 100 + 1);
                if (szamok.ContainsKey(szam))
                {
                    szamok[szam] = szamok[szam] + 1;
                } else
                {
                    szamok[szam] = 1;
                }
            }
            //A var kulcsszó használata esetén a fordító automatikusan
            //a megfelelő típust rendeli a változó nevéhez.

            var rendezettSzamok=szamok.OrderByDescending(x=>x.Key).ThenBy(x=>x.Value);

            foreach (KeyValuePair<int,int> szam in rendezettSzamok)
            {
                Console.WriteLine($"{szam.Key}==>{szam.Value}");
            }

            //Dictionary<string, int> elemek = new Dictionary<string, int> {

            //    {"I",1},{"II",2 },{"III",3},{"IV",4},{"V",5},{"VI",6},{"VII",7}
                
            //};

            //Console.WriteLine(elemek["I"]);
            ////Új kulcs-érték pár hozzáadása a szótárhoz
            //elemek.Add("VIII", 8);
            //elemek["IX"] = 9;

            ////kiíratás

            //foreach (KeyValuePair<string,int> elem in elemek)
            //{
            //    Console.WriteLine($"Kulcs:{elem.Key}, érték:{elem.Value}");
            //}

            ////Tartalmazás vizsgálata
            //Console.WriteLine(elemek.ContainsKey("IX"));
            //Console.WriteLine(elemek.ContainsKey("X"));
            //Console.WriteLine(elemek.ContainsValue(8));
            //Console.WriteLine(elemek.ContainsValue(11));


            Console.ReadKey();
        }
    }
}

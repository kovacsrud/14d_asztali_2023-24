using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ember
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Sportolo> sportolok = new List<Sportolo>();
            List<Nyugdijas> nyugdijasok = new List<Nyugdijas>();

            List<Ember> emberek = new List<Ember>();

            Sportolo sportolo = new Sportolo("triatlon", "Elek", 81, 180, 2003);

            sportolok.Add(sportolo);
            emberek.Add(sportolo);



            sportolo.Mozog();
            sportolo.Sportol();
            Console.WriteLine(sportolo.Eletkor());
            Console.WriteLine(sportolo.ToString());

            Nyugdijas nyugdijas = new Nyugdijas("Iván", 92, 186, 1951, "mérnök");

            emberek.Add(nyugdijas);

            Console.WriteLine(nyugdijas.Eletkor());
            nyugdijas.Mozog();
            Console.WriteLine(nyugdijas.ToString());


            Console.WriteLine(emberek[0].Eletkor());


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idojaras
{
    class Program
    {
        
        static void Main(string[] args)
        {

            IdojarasLista idojarasLista=null;
            try
            {
                idojarasLista = new IdojarasLista("idojaras.csv", ';');
                

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine(idojarasLista.IdojarasAdatok.Count);

            //var ev2006rendezett = idojarasLista.IdojarasAdatok.FindAll(x => x.Ev == 2006).OrderBy(x=>x.Ev);
            var ev2006 = idojarasLista.IdojarasAdatok.FindAll(x => x.Ev == 2006);

            //foreach (var i in ev2006)
            //{
            //    Console.WriteLine($"{i.Ev},{i.Honap},{i.Nap},{i.Homerseklet}");
            //}

            //Melyik volt 2006-ban a legmelegebb nap?
            var ev2006MaxHo = ev2006.Max(x => x.Homerseklet);

            var legmelegebb2006 = ev2006.Find(x => x.Homerseklet == ev2006MaxHo);

            //Rendezett listában a where-el lehet keresni
            //var MaxHo2006 = ev2006.Where(x => x.Homerseklet == ev2006MaxHo);

            //Console.WriteLine($"{MaxHo2006.First().Honap},{MaxHo2006.First().Nap}");


            Console.WriteLine($"2006-ban a legmelegebb nap:{legmelegebb2006.Honap}.{legmelegebb2006.Nap}");


            //Console.WriteLine(ev2006MaxHo);
            //A leghidegebb nap 2006-ban?

            //A teljes időszakban a legmelegebb/leghidegebb nap

            var legmelegebb = idojarasLista.IdojarasAdatok.Max(x => x.Homerseklet);
            var leghidegebb = idojarasLista.IdojarasAdatok.Min(x => x.Homerseklet);

            Console.WriteLine($"Max:{legmelegebb},Min:{leghidegebb}");

            var MaxHomNap = idojarasLista.IdojarasAdatok.Find(x => x.Homerseklet == legmelegebb);
            var MinHomNap = idojarasLista.IdojarasAdatok.Find(x => x.Homerseklet == leghidegebb);

            Console.WriteLine($"Legmelegebb nap:{MaxHomNap.Ev}.{MaxHomNap.Honap}.{MaxHomNap.Nap} {MaxHomNap.Ora}");
            Console.WriteLine($"Leghidegebb nap:{MinHomNap.Ev}.{MinHomNap.Honap}.{MinHomNap.Nap} {MinHomNap.Ora}");


            Console.ReadKey();
        }
    }
}

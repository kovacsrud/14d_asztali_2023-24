using System;
using System.Collections.Generic;
using System.IO;
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

            //Összesítések
            //Évenkénti átlaghőmérséklet
            var evesAtlagHo = idojarasLista.IdojarasAdatok.ToLookup(x=>x.Ev).OrderBy(x=>x.Key);

            foreach (var i in evesAtlagHo)
            {
                Console.WriteLine($"{i.Key} -> {i.Average(x=>x.Homerseklet)} Max:{i.Max(x=>x.Homerseklet)} Min:{i.Min(x=>x.Homerseklet)}");
            }

            //Átlaghőmérséklet Évenként és hónaponként

            var haviAtlagHo = idojarasLista.IdojarasAdatok.ToLookup(x => new {x.Ev,x.Honap}).OrderBy(x=>x.Key.Ev).ThenBy(x=>x.Key.Honap);

            foreach (var i in haviAtlagHo)
            {
                Console.WriteLine($"{i.Key.Ev}.{i.Key.Honap} {i.Average(x=>x.Homerseklet)}");
            }

            //Évenként, hónaponként, naponként

            var napiAtlagHo = idojarasLista.IdojarasAdatok.ToLookup(x => new { x.Ev, x.Honap,x.Nap })
                .OrderBy(x=>x.Key.Ev)
                .ThenBy(x=>x.Key.Honap)
                .ThenBy(x=>x.Key.Nap);

            foreach (var i in napiAtlagHo)
            {
                Console.WriteLine($"{i.Key.Ev}.{i.Key.Honap}.{i.Key.Nap} {i.Average(x => x.Homerseklet)}");
            }

            try
            {
                FileStream fajl = new FileStream("statisztika.txt",FileMode.Create);

                using (StreamWriter writer = new StreamWriter(fajl, Encoding.Default))
                {
                    writer.WriteLine($"ev;honap;nap;atlaghomerseklet");
                    foreach (var i in napiAtlagHo)
                    {
                        writer.WriteLine($"{i.Key.Ev};{i.Key.Honap};{i.Key.Nap};{i.Average(x=>x.Homerseklet)}");
                    }
                }

                Console.WriteLine("Kiírás kész!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.ReadKey();
        }
    }
}

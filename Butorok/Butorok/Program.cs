using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butorok
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<Szekreny> szekrenyek = new List<Szekreny>();
            List<Asztal> asztalok = new List<Asztal>();

            Asztal asztal = new Asztal
            {
                Alak = Alakok.kör,
                Anyag = Anyagok.fa,
                Fiokos = false,
                MaxMagassag = 110,
                Suly = 12
            };

            Szekreny szekreny = new Szekreny
            {
                Anyag = (Anyagok)rand.Next(0,2+1),
                Kulcsos = true,
                MaxMagassag = 200,
                Suly = 50,
                Uveges = false

            };

            Console.WriteLine(szekreny.Anyag);
            //Készítsünk egy 100 elemű listát szekrényekből
            //Minden adatot generáljunk!

            bool[] logikai = { true, false };

            for (int i = 0; i < 100; i++)
            {
                szekrenyek.Add(
                    new Szekreny
                    {
                        Anyag = (Anyagok)rand.Next(0, 2 + 1),
                        Kulcsos = logikai[rand.Next(0, 1 + 1)],
                        MaxMagassag = rand.Next(50, 250 + 1),
                        Suly=rand.Next(5,100+1),
                        Uveges= logikai[rand.Next(0, 1 + 1)]
                    }
                    ); ; ;
            }

            Console.WriteLine(szekrenyek.Count);

            foreach (var i in szekrenyek)
            {
                Console.WriteLine($"{i.Anyag},{i.Kulcsos},{i.MaxMagassag},{i.Suly},{i.Uveges}");
            }

            for (int i = 0; i < 100; i++)
            {
                asztalok.Add(
                    new Asztal
                    {
                        Alak = (Alakok)rand.Next(0, 3 + 1),
                        Anyag = (Anyagok)rand.Next(0, 2 + 1),
                        Fiokos = logikai[rand.Next(0, 1 + 1)],
                        MaxMagassag = rand.Next(40, 120 + 1),
                        Suly=rand.Next(5,100+1)
                    }
                    ); 
            }
            Console.WriteLine("-----------------------------------------------");
            foreach (var i in asztalok)
            {
                Console.WriteLine($"{i.Alak},{i.Anyag},{i.Fiokos},{i.MaxMagassag},{i.Suly}");
            }

            //Visszakeresés a listából
            //kör alakú asztalok
            List<Asztal> korAsztalok = new List<Asztal>();

            for (int i = 0; i < asztalok.Count; i++)
            {
                if (asztalok[i].Alak==Alakok.kör)
                {
                    korAsztalok.Add(asztalok[i]);
                }
            }

            foreach (var i in korAsztalok)
            {
                Console.WriteLine($"{i.Alak},{i.Anyag},{i.Fiokos},{i.MaxMagassag},{i.Suly}");
            }

            var korasztalok2 = asztalok.FindAll(x=>x.Alak==Alakok.kör);

            foreach (var i in korasztalok2)
            {
                Console.WriteLine($"{i.Alak},{i.Anyag},{i.Fiokos},{i.MaxMagassag},{i.Suly}");
            }

            var egyAsztal = asztalok.Find(x => x.Suly < 4);


            if (egyAsztal!=null)
            {
                Console.WriteLine($"{egyAsztal.Suly}");
            } else
            {
                Console.WriteLine("Nincs ilyen asztal!");
            }
            
              //A szekrények közül listázza ki
              //a fém anyagúakat
              //az egy méternél alacsonyabb üveges szekrényeket
              //50 kilónál nehezebb kulcsos fa anyagú szekrényeket

            
            
            

            Console.ReadKey();
        }
    }
}

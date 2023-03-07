using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FajlokReadall
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autok = new List<Auto>();

            try
            {
                var sorok = File.ReadAllLines("autoadat.csv", Encoding.Default);

                for (int i = 1; i < sorok.Length; i++)
                {
                    autok.Add(new Auto(sorok[i], ';'));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Az autók száma:{autok.Count} db.");

            var focusok = autok.FindAll(x => x.Marka.ToLower() == "FOCUS".ToLower());

            foreach (var i in focusok)
            {
                Console.WriteLine($"{i.Tipus},{i.Üzem},{i.Evjarat},{i.Ar}");
            }
            //Swift-ek adatai, amelyek 2006 előtt lettek gyártva
            var swiftek = autok.FindAll(x => x.Marka.ToLower().Trim() == "swift");
            foreach (var i in swiftek)
            {
                Console.WriteLine($"{i.Tipus},{i.Üzem},{i.Evjarat},{i.Ar}");
            }

            //klímás autók
            var klimas = autok.FindAll(x => x.Tipus.ToLower().Contains("klima") || x.Tipus.ToLower().Contains("klíma"));
            foreach (var i in klimas)
            {
                Console.WriteLine($"{i.Tipus},{i.Üzem},{i.Evjarat},{i.Ar}");
            }

            //írjuk fájlba a klímás autók adatait!

            try
            {
                FileStream fajl = new FileStream("klimas_autok_using.txt", FileMode.Create);
                //StreamWriter writer = new StreamWriter(fajl, Encoding.Default);
                //writer.WriteLine("Id;Márka;Típus;Évjárat;Üzem;Hengerűrtartalom;Teljesítmény(le);Futott km;Ár");
                //foreach (var i in klimas)
                //{
                //    writer.WriteLine($"{i.Id};{i.Marka};{i.Tipus};{i.Evjarat};{i.Üzem};{i.HengerUrtartalom};{i.Teljesitmeny};{i.FutottKm};{i.Ar}");
                //}

                //writer.Close();
                using (StreamWriter writer = new StreamWriter(fajl, Encoding.Default))
                {
                    writer.WriteLine("Id;Márka;Típus;Évjárat;Üzem;Hengerűrtartalom;Teljesítmény(le);Futott km;Ár");
                    foreach (var i in klimas)
                    {
                        writer.WriteLine($"{i.Id};{i.Marka};{i.Tipus};{i.Evjarat};{i.Üzem};{i.HengerUrtartalom};{i.Teljesitmeny};{i.FutottKm};{i.Ar}");
                    }
                }
                Console.WriteLine("Fájlba írás kész!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }


            Console.ReadKey();
        }
    }
}

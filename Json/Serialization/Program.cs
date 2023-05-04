using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToplistaElem> toplista = new List<ToplistaElem>();

            toplista.Add(new ToplistaElem("TheKing", 8000));
            toplista.Add(new ToplistaElem("TheMaster", 7500));
            toplista.Add(new ToplistaElem("NoPingJustLag", 6500));
            toplista.Add(new ToplistaElem("NoSkillJustLuck", 6000));
            toplista.Add(new ToplistaElem("JustSkillNoLuck", 5000));

            var jsonSerializer = new JsonSerializer();
            var jsonFajl = new JsonTextWriter(new StreamWriter("toplista.json"));

            jsonSerializer.Serialize(jsonFajl, toplista);

            jsonFajl.Close();

            Console.WriteLine("Kész");

            
            if (File.Exists("toplista.json"))
            {
                var jsonBetolt = new JsonTextReader(new StreamReader("toplista.json"));
                List<ToplistaElem> jsonVissza = jsonSerializer.Deserialize<List<ToplistaElem>>(jsonBetolt);

                foreach (var i in jsonVissza)
                {
                    Console.WriteLine($"{i.Nev}:{i.Pontszam}");
                }

            }

            



            Console.ReadKey();
        }
    }
}

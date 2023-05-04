using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            string nevsor = "";

            try
            {
                nevsor = File.ReadAllText("nevsor.json", Encoding.UTF8);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }

            JObject nevek = JObject.Parse(nevsor);

            Console.WriteLine(nevek["nevsor"].Count());
            Console.WriteLine(nevek["nevsor"][0]["nev"]);
            Console.WriteLine(nevek["nevsor"][1]["nev"]);

            for (int i = 0; i < nevek["nevsor"].Count(); i++)
            {
                Console.WriteLine($"{nevek["nevsor"][i]["id"]}-{nevek["nevsor"][i]["nev"]}");
                if (nevek["nevsor"][i]["ismerosok"]!=null)
                {
                    for (int j = 0; j < nevek["nevsor"][i]["ismerosok"].Count(); j++)
                    {
                        Console.WriteLine(nevek["nevsor"][i]["ismerosok"][j]["nev"]);
                    }
                }
            }


            Console.ReadKey();
        }
    }
}

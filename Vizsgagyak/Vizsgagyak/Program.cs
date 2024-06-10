using System.Text;


namespace Vizsgagyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dolgozo> dolgozok = new List<Dolgozo>();

            try
            {
                var sorok = File.ReadAllLines("dolgozok_pv.csv",Encoding.Default);

                for (int i = 1; i < sorok.Length; i++)
                {
                    dolgozok.Add(new Dolgozo(sorok[i]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine($"Sorok száma:{dolgozok.Count}");

            //Hány Quality Engineer van?
            var qe = dolgozok.FindAll(x => x.Foglalkozas.ToLower() == "Quality Engineer".ToLower()).Count;

            Console.WriteLine($"Quality engineer:{qe}");

            //Hányféle foglalkozás van? Az egyes foglalkozásoknak hány dolgozója van?

            //var foglalkozasStat = dolgozok.ToLookup(x => x.Foglalkozas).OrderBy(x => x.Key);
            var foglalkozasStat = dolgozok.ToLookup(x=>x.Foglalkozas).OrderByDescending(x=>x.Count());

            foreach (var i in foglalkozasStat)
            {
                Console.WriteLine($"{i.Key} - {i.Count()}");
            }


        }
    }


}



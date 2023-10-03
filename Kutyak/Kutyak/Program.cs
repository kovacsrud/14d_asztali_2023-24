using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Kutyak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kutyak> kutyak=new List<Kutyak>();
            List<Kutyanev> kutyanevek=new List<Kutyanev>();
            List<Kutyafajta> kutyafajtak=new List<Kutyafajta>();

            try
            {
                kutyak = new KutyaLista("kutyak.csv", ';').Kutyak;
                kutyanevek = new KutyanevLista("kutyanevek.csv",';').Kutyanevek;
                kutyafajtak = new KutyafajtaLista("kutyafajtak.csv", ';').Kutyafajtak;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine($"Nevek:{kutyanevek.Count},Fajták:{kutyafajtak.Count},Rendelés adatok:{kutyak.Count}");

            var atlagEletkor = kutyak.Average(x=>x.Eletkor);
            Console.WriteLine($"Kutyák átlagéletkora:{atlagEletkor:0.00}");

            var kutyak_kutyanev = kutyak.Join(kutyanevek, k => k.NevId, kn => kn.Id, (k, kn) => new {k.Eletkor,k.UtolsoEll,k.FajtaId,k.NevId,k.Id,kn.KutyaNev});

            //foreach (var i in kutyak_kutyanev)
            //{
            //    Console.WriteLine($"{i.Eletkor},{i.KutyaNev}");
            //}

            var kutyak_kutyanev_kutyafajta = kutyak_kutyanev.Join(kutyafajtak,kkn=>kkn.FajtaId,kf=>kf.Id,(kkn,kf)=>new {kkn.Id,kkn.NevId,kkn.FajtaId,kkn.Eletkor,kkn.UtolsoEll,kkn.KutyaNev,kf.EredetiNev,kf.Nev}).ToList();

            var legidosebb = kutyak_kutyanev_kutyafajta.Find(x=>x.Eletkor==kutyak_kutyanev_kutyafajta.Max(y=>y.Eletkor));

            Console.WriteLine($"Legidősebb kutya neve:{legidosebb?.Nev}, kora:{legidosebb?.Eletkor}");

            var adottNap = kutyak_kutyanev_kutyafajta.FindAll(x=>x.UtolsoEll.Year==2018 && x.UtolsoEll.Month==1 && x.UtolsoEll.Day==10);

            var stat = adottNap.ToLookup(x=>x.Nev).OrderBy(x=>x.Key);

            foreach (var i in stat)
            {
                Console.WriteLine($"{i.Key} - {i.Count()}");
            }

            var maxLeterhelt = kutyak_kutyanev_kutyafajta.ToLookup(x=>new {x.UtolsoEll.Year,x.UtolsoEll.Month,x.UtolsoEll.Day}).OrderByDescending(x=>x.Count());

            //foreach (var i in maxLeterhelt)
            //{
            // Console.WriteLine($"{i.Key.Year}.{i.Key.Month}.{i.Key.Day} - {i.Count()} kutya ellátva.");
            //}

            Console.WriteLine($"Legnagyobb leterhelés:{maxLeterhelt.First().Key.Year}.{maxLeterhelt.First().Key.Month}.{maxLeterhelt.First().Key.Day} - {maxLeterhelt.First().Count()} kutya ellátva.");

            var nevstat = kutyak_kutyanev_kutyafajta.ToLookup(x=>x.KutyaNev).OrderByDescending(x=>x.Count());

            var fajtaStat=kutyak_kutyanev_kutyafajta.ToLookup(x=>x.Nev).OrderByDescending(x=>x.Count());

            foreach (var i in fajtaStat)
            {
                Console.WriteLine($"{i.Key} - {i.Count()}");
            }

            try
            {
                FileStream fajl=new FileStream("nevstatisztika.txt",FileMode.Create);

                using (StreamWriter writer = new StreamWriter(fajl, Encoding.Default))
                {
                    foreach (var i in nevstat)
                    {
                        writer.WriteLine($"{i.Key};{i.Count()}");
                    } 
                }
                Console.WriteLine("Adatok kiírva!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
using System.Text;

namespace CarSales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Carlist carlist = new Carlist("car_sales_data_v2.csv", ';');

            cars=carlist.Cars;

            Console.WriteLine($"Lista elemszám:{cars.Count}");

            var orszagokSzama = cars.ToLookup(x => x.Country).Count;

            Console.WriteLine($"Az országok száma:{orszagokSzama}");

            var orszagok = cars.ToLookup(x => x.Country).OrderBy(x=>x.Key);

            foreach(var c in orszagok)
            {
                Console.WriteLine(c.Key);
            }

            var ev2010 = cars.FindAll(x => x.Year == 2010);
            var maxauto2010 = ev2010.Max(x => x.Sale);

            var legtobbet2010 = ev2010.Find(x => x.Sale == maxauto2010);

            Console.WriteLine($"2010-ben a legtöbb autót eladta:{legtobbet2010.Country}");

            var maxautoAll=cars.Max(x => x.Sale); 

            var legtobbetEladta=cars.Find(x=>x.Sale == maxautoAll);

            var legtobbetDarab=cars.FindAll(x=>x.Sale==maxautoAll);

            Console.WriteLine($"Legtöbb eladás darabszáma:{legtobbetDarab.Count}");

            Console.WriteLine($"A legtöbb autót eladta:{legtobbetEladta.Country}");

            Console.WriteLine($"Ebben az évben adták el a legtöbb autót:{legtobbetEladta.Year}");

            var nemnullaEladasok = cars.FindAll(x=>x.Sale>0);

            var minEladas=nemnullaEladasok.Min(x=>x.Sale);

            var legkevesebbetEladta = nemnullaEladasok.FindAll(x => x.Sale == minEladas);

            foreach (var i in legkevesebbetEladta)
            {
                Console.WriteLine($"A legkevesebb autót eladó ország:{i.Country}, a {i.Year} évben");
            }

            try
            {
                FileStream fajl = new FileStream("output.txt", FileMode.Create);
                using (StreamWriter writer=new StreamWriter(fajl,Encoding.Default))
                {
                    writer.WriteLine("country;year;sale");

                    foreach(var i in cars)
                    {
                        writer.WriteLine($"{i.Country};{i.Year};{i.Sale}");
                    }
                }
                Console.WriteLine("Adatok fájlba írva!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}

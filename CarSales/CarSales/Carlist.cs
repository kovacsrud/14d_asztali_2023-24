using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSales
{
    public class Carlist
    {
        public List<Car> Cars { get; set; } = new List<Car>();

        public Carlist(string fajl,char hatarolo,int start=1)
        {
            try
            {
                var sorok=File.ReadAllLines(fajl,Encoding.Default);

                var fejlec = sorok[0].Split(hatarolo);

                for (int i = start; i < sorok.Length; i++)
                {
                    var adatsor = sorok[i].Split(hatarolo);
                    var country = adatsor[0];
                    for (int j = 1; j < adatsor.Length; j++)
                    {
                        var ev = Convert.ToInt32(fejlec[j].Substring(0,4));

                        int eladas = 0;

                        if (adatsor[j]!="")
                        {
                            eladas = Convert.ToInt32(adatsor[j].Replace(",", ""));
                        }

                        Cars.Add(new Car(country,ev,eladas));

                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

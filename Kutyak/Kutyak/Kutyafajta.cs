using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class Kutyafajta
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public string EredetiNev { get; set; }

        public Kutyafajta(string sor,char hatarolo)
        {
            var adatok = sor.Split(hatarolo);
            Id = Convert.ToInt32(adatok[0]);
            Nev = adatok[1];
            EredetiNev = adatok[2];
        }
    }
}

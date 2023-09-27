using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfKolcsonzes.mvvm.models
{
    public class Kolcsonzes
    {
        public string Nev { get; set; }
        public char Jazon { get; set; }
        public int Eora { get; set; }
        public int Eperc { get; set; }
        public int Vora { get; set; }
        public int Vperc { get; set; }

        public Kolcsonzes(string sor,char hatarolo)
        {
            var adat = sor.Split(hatarolo);
            Nev = adat[0];
            Jazon = Convert.ToChar(adat[1]);
            Eora = Convert.ToInt32(adat[2]);
            Eperc = Convert.ToInt32(adat[3]);
            Vora = Convert.ToInt32(adat[4]);
            Vperc = Convert.ToInt32(adat[5]);
        }
    }
}

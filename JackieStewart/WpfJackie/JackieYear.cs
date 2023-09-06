using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfJackie
{
    public class JackieYear 
    {
        public int Year { get; set; }
        public int Races { get; set; }
        public int Wins { get; set; }
        public int Podiums { get; set; }
        public int Poles { get; set; }
        public int Fastests { get; set; }

        public JackieYear(string sor,char hatarolo)
        {
            var adat = sor.Split(hatarolo);
            Year = Convert.ToInt32(adat[0]);
            Races = Convert.ToInt32(adat[1]);
            Wins = Convert.ToInt32(adat[2]);
            Podiums = Convert.ToInt32(adat[3]);
            Poles = Convert.ToInt32(adat[4]);
            Fastests = Convert.ToInt32(adat[5]);
        }
    }
}

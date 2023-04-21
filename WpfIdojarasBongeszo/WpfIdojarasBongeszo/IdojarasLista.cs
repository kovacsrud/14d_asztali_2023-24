using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIdojarasBongeszo
{
    public class IdojarasLista
    {
        public List<Idojaras> IdojarasAdatok { get; set; }

        public IdojarasLista(string fajl,char hatarolo,int start=1)
        {
            IdojarasAdatok = new List<Idojaras>();

            var sorok = File.ReadAllLines(fajl,Encoding.Default);

            for (int i = start; i < sorok.Length; i++)
            {
                IdojarasAdatok.Add(new Idojaras(sorok[i], ';'));
            }
        }

        public List<int> GetEvek()
        {
            List<int> evek = new List<int>();
            var evStat = IdojarasAdatok.ToLookup(x=>x.Ev).OrderBy(x=>x.Key);

            foreach (var i in evStat)
            {
                evek.Add(i.Key);
            }


            return evek;
        }

        public List<int> GetHonapok(int ev)
        {
            List<int> honapok = new List<int>();
            var aktualisEv = IdojarasAdatok.FindAll(x=>x.Ev==ev);
            var honapStat = IdojarasAdatok.ToLookup(x => x.Honap).OrderBy(x=>x.Key);

            foreach (var i in honapStat)
            {
                honapok.Add(i.Key);
            }


            return honapok;
        }

        public IOrderedEnumerable<Idojaras> GetAdatok(int ev)
        {
            var adatok = IdojarasAdatok.FindAll(x => x.Ev == ev).OrderBy(x=>x.Honap).ThenBy(x=>x.Nap).ThenBy(x=>x.Ora);

            return adatok;
        }
    }
}

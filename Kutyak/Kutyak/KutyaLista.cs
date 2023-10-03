using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class KutyaLista
    {
        public List<Kutyak> Kutyak { get; set; } = new List<Kutyak>();

        public KutyaLista(string fajl,char hatarolo,int start=1)
        {
            var sorok = File.ReadAllLines(fajl, Encoding.Default);

            for (int i = start; i < sorok.Length; i++)
            {
                Kutyak.Add(new Kutyak(sorok[i], hatarolo));
            }
        }
    }
}

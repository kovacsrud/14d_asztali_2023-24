using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfKolcsonzes.mvvm.models
{
    public class KolcsonzoLista
    {
        public List<Kolcsonzes> Kolcsonzesek { get; set; } = new List<Kolcsonzes>();

        public KolcsonzoLista(string fajl,char hatarolo,int start=1)
        {
            var sorok = File.ReadAllLines(fajl, Encoding.Default);
            for (int i = start; i < sorok.Length; i++)
            {
                Kolcsonzesek.Add(new Kolcsonzes(sorok[i], hatarolo));
            }
        }
    }
}

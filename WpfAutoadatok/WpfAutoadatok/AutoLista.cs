using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WpfAutoadatok
{
    public class AutoLista
    {
        public List<Auto> Autok { get; set; }

        public AutoLista(string fajl,char hatarolo,int start=1)
        {
            Autok = new List<Auto>();

            var sorok = File.ReadAllLines(fajl, Encoding.UTF7);

            for (int i = start; i < sorok.Length; i++)
            {
                Autok.Add(new Auto(sorok[i], hatarolo));
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Idojaras
{
    public class IdojarasLista
    {
        private List<IdojarasAdat> idojarasAdatok;
        public List<IdojarasAdat> IdojarasAdatok { get { return idojarasAdatok; } }

        public IdojarasLista(string fajl,char hatarolo,int start=1)
        {
            idojarasAdatok = new List<IdojarasAdat>();

            //?? try-catch ??
            var sorok = File.ReadAllLines(fajl, Encoding.Default);

            for (int i = start; i < sorok.Length; i++)
            {
                idojarasAdatok.Add(new IdojarasAdat(sorok[i],hatarolo));
            }

            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackieStewart
{
    public class ListBuild
    {
        public List<JackieYear> JackieYears { get; set; }

        public ListBuild(string file,char hatarolo,int start=1)
        {
            JackieYears = new List<JackieYear>();

            var sorok = File.ReadAllLines(file, Encoding.Default);    

            for (int i = start; i < sorok.Length; i++)
            {
                JackieYears.Add(new JackieYear(sorok[i],hatarolo));
            } 

        }
    }
}

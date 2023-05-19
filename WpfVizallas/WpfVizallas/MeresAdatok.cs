using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVizallas
{
   

    public class MeresAdatok
    {
        public List<Meresek> meresek { get; set; }
    }

    public class Meresek
    {
        public int id { get; set; }
        public int vmId { get; set; }
        public string nap { get; set; }
        public string ido { get; set; }
        public int vizAllas { get; set; }
    }

}

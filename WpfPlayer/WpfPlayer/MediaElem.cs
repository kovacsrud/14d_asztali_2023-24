using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPlayer
{
    public class MediaElem
    {
        public string TeljesUtvonal { get; set; }
        public string Fajlnev { get; set; }

        public MediaElem(string teljesutvonal,char separator)
        {
            TeljesUtvonal = teljesutvonal;
            Fajlnev=teljesutvonal.Split(separator).Last();
        }
    }
}

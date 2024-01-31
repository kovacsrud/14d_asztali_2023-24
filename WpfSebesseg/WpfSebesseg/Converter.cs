using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSebesseg
{
    public static class Converter
    {
        public static double KmhToMs(double kmh)
        {
            return kmh / 3.6;
        }

        public static double KmhToMph(double kmh)
        {
            return kmh / 1.6;
        }
    }
}

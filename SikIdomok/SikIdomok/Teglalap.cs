using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikIdomok
{
    class Teglalap : ISikidom
    {
        public double A { get; set; }
        public double B { get; set; }
        public Teglalap(double a, double b)
        {
            A = a;
            B = b;
        }        

        public double Kerulet()
        {
            return (A + B) * 2;
        }

        public double Terulet()
        {
            return A * B;
        }

        public override string ToString()
        {
            return $"Téglalap, A:{A},B:{B}";
        }
    }
}

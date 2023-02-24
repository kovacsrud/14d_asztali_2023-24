using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamitogep
{
    class Szamitogep
    {
        private double szabadMemoria;
        private bool bekapcsolva;

        public Szamitogep()
        {
            szabadMemoria = 1024;
            bekapcsolva = false;
        }

        public Szamitogep(double szabadmemoria,bool bekapcsolva)
        {
            szabadMemoria = szabadmemoria;
            this.bekapcsolva = bekapcsolva;
        }

        public void Kapcsol()
        {
            bekapcsolva = !bekapcsolva;
        }

        public bool Masolas(double programMeret)
        {
            bool sikeresMasolas = false;
            if (programMeret<szabadMemoria && bekapcsolva)
            {
                szabadMemoria -= programMeret;
                sikeresMasolas = true;
            } else
            {
                sikeresMasolas = false;
            }

            return sikeresMasolas;
        }

        public override string ToString()
        {
            string allapot = "";

            if (bekapcsolva)
            {
                allapot += "A gép be van kapcsolva.";
            } else
            {
                allapot += "A gép ki van kapcsolva.";
            }

            allapot += $" Szabad memória:{szabadMemoria}";
            
            return allapot;
        }
    }
}

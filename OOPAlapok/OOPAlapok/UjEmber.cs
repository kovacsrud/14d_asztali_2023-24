using System;

namespace OOPAlapok
{
    class UjEmber
    {
        public string Nev { get; set; }

        private int magassag;
        public int Magassag {
            get { return magassag; }
            set { 
                if(value<60 || value > 260)
                {
                    throw new ArgumentException();
                } else
                {
                    magassag = value;
                }           
            } }
        public int Suly { get; set; }
        public string SzuletesiHely { get; set; }
        public string SzemelyiSzam { get; set; }
    }
}
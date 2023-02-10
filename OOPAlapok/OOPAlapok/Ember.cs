using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    class Ember
    {
        //Az osztály adatokat (változók,adattag) és műveleteket
        //(metódus, függvény) tartalmazhat.

       //Az oop egyik alapelve a bezártság (encapsulation)
       //Az osztály egy interfészen keresztül lehessen elérhető
        
       private string nev;
       private string szuletesiHely;
       private int magassag;
       private int suly;

        //Konstruktor függvény: az osztály példányosításakor 
        //automatikusan lefut
        //Nincs visszatérési értéke, és void sem lehet, a nevének meg kell 
        //egyeznie az osztály nevével
        public Ember(string nev,string szuletesiHely,int magassag,int suly)
        {
            this.nev = nev;
            this.szuletesiHely = szuletesiHely;
            this.magassag = magassag;
            this.suly = suly;
        }

        public Ember()
        {
                
        }

        public string GetNev()
        {
            return nev;
        }

        public void SetNev(string nev)
        {

            this.nev = nev;
        }

        public void SetMagassag(int magassag)
        {
            if (magassag<80)
            {
                throw new ArgumentException("Hibás érték");
            } else
            {
                this.magassag = magassag;
            }
        }

        public int GetMagassag()
        {
            return magassag;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Példányosítás
            Ember ubul = new Ember("Ubul","Kaba",187,87);
            Ember elek = new Ember("Elek","Szeged",176,78);
            Ember geza = new Ember();

            EmberProp emberp = new EmberProp("Éva","Cegléd",169,56);

            Console.WriteLine(emberp.Nev);

            EmberProp emberp2 = new EmberProp {
                Nev="Tamás",
                Magassag=188,
                Suly=89,
                SzuletesiHely="Orosháza"
            };

            UjEmber ujember = new UjEmber
            {
                Nev = "József",
                Magassag = 199,
                Suly = 91,
                SzuletesiHely = "Szeged",
                SzemelyiSzam = "37606125123"
            };

            Console.WriteLine(emberp2.Nev);

            //ubul.SetNev("Ubul");
            //ubul.SetMagassag(190);

            //Console.WriteLine(ubul.GetNev());
            //Console.WriteLine(ubul.GetMagassag());

            //ubul.nev = "Ubul";
            //ubul.magassag = 176;
            //ubul.suly = 69;
            //ubul.szuletesiHely = "Kaba";

            //Console.WriteLine(ubul.nev);


            Console.ReadKey();
        }
    }
}

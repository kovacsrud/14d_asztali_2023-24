using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggvenyek
{
    class Program
    {

        //Függvény túlterhelés (overloading)
        //Több azonos nevű függvényem lehet, de különbözniük 
        //kell a paraméterlistában
        static void Kiir(string szoveg,string alap="Alapérték")
        {
            Console.WriteLine(alap+" "+szoveg);
        }
        //static void Kiir(string szoveg)
        //{
        //    Console.WriteLine(szoveg);
        //}
        //static void Kiir(string szoveg,string szoveg2)
        //{
        //    Console.WriteLine(szoveg+" "+szoveg2);
        //}

        static int Osszead(int a,int b)
        {
            return a + b;
        }

        static double Osszead(double a,double b)
        {
            return a + b;
        }

        static int Osztas(int a,int b)
        {
            return a / b;
        }

        static double Osztas(double a,double b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            Kiir("Csak egy string");
            Kiir("Paraméter","A");
            Kiir("Valami","Bármi");
            Kiir("Bármi","Akármi");
            string szoveg = "Akármi";
            Kiir(szoveg,"Valami");
            Kiir(szoveg);
            int osszeg = Osszead(10, 22);
            Console.WriteLine(osszeg);
            Console.WriteLine(Osszead(100,300));

            Console.WriteLine(Osszead(11.567,6678.44566));
            Console.WriteLine(Osztas(23,1));
            Console.WriteLine(Osztas(23.678,0));
            


            Console.ReadKey();
        }

    }
}

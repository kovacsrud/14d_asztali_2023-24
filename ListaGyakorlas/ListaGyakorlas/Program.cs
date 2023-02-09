using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaGyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            Random rand = new Random();

            Feltoltes(szamok,rand);
            Lista(szamok);
            Osszesites(szamok);

            Console.ReadKey();
        }

        private static void Osszesites(List<int> szamok)
        {
            Console.WriteLine($"Össz:{szamok.Sum()},Átlag:{szamok.Average():0.00},Min:{szamok.Min()},Max:{szamok.Max()}");
        }

        private static void Lista(List<int> szamok)
        {
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.Write(szamok[i] + " ");
            }
        }

        private static void Feltoltes(List<int> szamok,Random rand)
        {
            for (int i = 0; i < rand.Next(50, 100 + 1); i++)
            {
                szamok.Add(rand.Next(-200, 200 + 1));
            }
        }
    }
}

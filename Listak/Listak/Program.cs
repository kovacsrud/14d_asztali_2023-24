using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            Random rand = new Random();

            Console.WriteLine(szamok.Count);
            szamok.Add(123);
            szamok.Add(566);

            for (int i = 0; i < 20; i++)
            {
                szamok.Add(rand.Next(100, 600 + 1));
            }

            //Lista for-al
            Lista(szamok);

            //Foreach
            //foreach (var i in szamok)
            //{
            //    Console.WriteLine(i);
            //}

            szamok.RemoveAt(0);
            Lista(szamok);
            szamok.RemoveAt(1);
            Lista(szamok);

            szamok.Remove(566);
            Lista(szamok);
            bool torol = szamok.Remove(221);
            Console.WriteLine($"Törölve:{torol}");

            Console.WriteLine($"Min:{szamok.Min()},Max:{szamok.Max()},Összeg:{szamok.Sum()}");

            Console.WriteLine($"A számok között van-e 115:{szamok.Contains(115)}");

            //Másik lista hozzáadása
            List<int> szamok2 = new List<int>();

            szamok2.Add(1);
            szamok2.Add(2);
            szamok2.Add(3);

            szamok.AddRange(szamok2);

            Lista(szamok);

            szamok.RemoveRange(2,3);
            szamok.RemoveRange(szamok.Count - 3, 3);
            Lista(szamok);
            //??

            szamok.Clear();
            Lista(szamok);

            Console.ReadKey();
        }

        private static void Lista(List<int> szamok)
        {
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.Write(szamok[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------");
        }
    }
}

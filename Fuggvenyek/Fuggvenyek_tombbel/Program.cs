using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggvenyek_tombbel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t1 = { 12, 345, 32, 566, 78, 333, 5 };
            int[] t2 = { 44, 69, 112, 443, 13, 31 };
            int[] t3 = { 199, 567, 331, 669, 927, 1015, 448 };
            int[] t4 = { 551, 339, 1223, 667, 3, 8, 99, 51 };

            TombLista(t1);
            TombLista(t2);
            TombLista(t3);
            TombLista(t4);

            Console.ReadKey();
        }

        private static void TombLista(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

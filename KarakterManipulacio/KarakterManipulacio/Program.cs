using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterManipulacio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Karakterek manipulációja

            string szoveg = "vALAmi sZövEg";
            Console.WriteLine(szoveg);

            char[] szovegTomb = szoveg.ToCharArray();


            for (int i = 0; i < szovegTomb.Length; i++)
            {
                if (Char.IsLower(szoveg[i]))
                {
                    szovegTomb[i] = Char.ToUpper(szovegTomb[i]);
                } else
                {
                    szovegTomb[i] = Char.ToLower(szovegTomb[i]);
                }
            }

            

            szoveg = new string(szovegTomb);

            Console.WriteLine(szoveg);

            Console.ReadKey();
        }
    }
}

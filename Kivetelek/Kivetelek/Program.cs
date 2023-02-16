using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetelek
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int a = 10;
                int b = 10;
                int c = a / b;
                Console.WriteLine(c);
              //  Console.WriteLine(szoveg);
                Console.WriteLine("További parancsok");

                try
                {
                   // throw new MissingFieldException();
                }
                catch (StackOverflowException ex)
                {

                    Console.WriteLine(ex.Message);
                }

                //throw new ArgumentException();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Hibás érték");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            finally
            {
                //Esetlegesen lefoglalt erőforrások
                //felszabadítása történik itt.
                Console.WriteLine("Ez a blokk mindig lefut");
            }

            Console.WriteLine("A program többi része");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fajlok
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fajl = null;
            StreamReader reader = null;
            try
            {
                fajl = new FileStream("autoadat.csv", FileMode.Open);
                reader = new StreamReader(fajl, Encoding.Default);
                reader.ReadLine();//Első sor átlépése
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }

                //Kivétel esetén elmarad a bezárás
                //reader.Close();

                    
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader!=null)
                {
                    reader.Close();
                }
                
            }


            Console.ReadKey();
        }
    }
}

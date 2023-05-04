using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KRHash;

namespace HashTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHash hash = new CreateHash();
            string h1 = hash.MakeHash(HashType.MD5, "hétfő");
            string h2 = hash.MakeHash(HashType.SHA1, "hétfő");
            string h3 = hash.MakeHash(HashType.SHA512, "hétfő");
            Console.WriteLine(h1);
            Console.WriteLine(h2);
            Console.WriteLine(h3);

            string fh1 = hash.MakeHash(HashType.MD5, "vb2018.txt");
            Console.WriteLine(fh1);


            Console.ReadKey();
        }
    }
}

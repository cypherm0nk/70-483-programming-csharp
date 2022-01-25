using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Listing3_23SHA2
{
    class Program
    {
        static byte[] calculateHash(string source)
        {
            ASCIIEncoding converter = new ASCIIEncoding();
            byte[] sourcebytes = converter.GetBytes(source);
            HashAlgorithm hasher = SHA256.Create();
            byte[] hash = hasher.ComputeHash(sourcebytes);
            return hash;
        }
        static void showHash(string source)
        {
            Console.Write("Hash form {0} is: ", source);
            byte[] hash = calculateHash(source);
            foreach (byte b in hash)
                Console.Write("{0:X} ", b);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            showHash("Hello world");
            showHash("world Hello");
            showHash("Hemmm world");
            Console.ReadKey();
        }
    }
}

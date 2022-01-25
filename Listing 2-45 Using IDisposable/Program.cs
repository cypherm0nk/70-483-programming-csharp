using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2_45_Using_IDisposable
{
    class CrucialConnection : IDisposable {
        public void Dispose() {
            Console.WriteLine("Dispose called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (CrucialConnection c = new CrucialConnection()) {

                
            }
            Console.ReadKey();
        }
    }
}

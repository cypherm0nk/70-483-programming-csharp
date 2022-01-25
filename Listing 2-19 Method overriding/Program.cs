using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_2_19_Method_overriding
{
    class Document
    {
        public void GetDate()
        {
            Console.WriteLine("Hello from GetDate in Document");
        }

        public virtual void DoPrint()
        {
            Console.WriteLine("Hello from DoPrint in Documento");
        }
    }
    class Invoice : Document
    {
        public override void DoPrint()
        {
            Console.WriteLine("Hello form DoPrint in Invoice");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Invoice c = new Invoice();
            c.GetDate();
            c.DoPrint();
            Console.ReadKey();
        }
    }
}

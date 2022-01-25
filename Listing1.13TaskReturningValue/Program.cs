using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Listing1._13TaskReturningValue
{
    class Program
    {
        public static int CalculateResult()
        {
            Console.WriteLine("Work starting");
            Thread.Sleep(2000);
            Console.WriteLine("Work finished");
            return 99;
        }
        static void Main(string[] args)
        {
            Task<int> task = Task.Run(() =>
            {
                return CalculateResult();
            });
            Console.WriteLine(task.Result);
            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listing1._16ContinuationOptions
{
    class Program
    {
        public static void HelloTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hello");
        }
        public static void WorldTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("world");
        }

        static void Main(string[] args)
        {
            Task task = Task.Run(()=>HelloTask());
            task.ContinueWith((prevTask)=>WorldTask(),TaskContinuationOptions.OnlyOnRanToCompletion);
            task.ContinueWith((prevTask)=>ExceptionTask(),TaskContinuationOptions.OnlyOnFaulted);
        }

        private static void ExceptionTask()
        {
            throw new NotImplementedException();
        }
    }
}

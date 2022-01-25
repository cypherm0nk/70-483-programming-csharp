using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Listing1._15ContinuationTasks
{
    class Program
    {
        public static void HelloTask() {
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
            task.ContinueWith((prevTask)=>WorldTask());
            Console.WriteLine("Finished processing. Press a key to end.");
            Console.ReadKey();
        }
    }
}

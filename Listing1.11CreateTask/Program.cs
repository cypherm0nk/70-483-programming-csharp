using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Listing1._11CreateTask
{
    class Program
    {
        public static void DoWork() {
            Console.WriteLine("Work starting");
            Thread.Sleep(2000);
            Console.WriteLine("Work finished");
        }
        static void Main(string[] args)
        {
            Task newTask = new Task(()=>DoWork());
            newTask.Start();
            newTask.Wait();
            Console.ReadKey();
        }
    }
}

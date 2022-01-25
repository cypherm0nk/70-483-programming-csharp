using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing2._6_Using_generic_types
{
    class Program
    {
        class MyStack<T>
        {
            int stackTop = 0;
            T[] items = new T[100];
            public void Push(T item)
            {
                if (stackTop == items.Length)
                    throw new Exception("Stack Full");
                items[stackTop] = item;
                stackTop++;
            }
            public T Pop() {
                if (stackTop == 0)
                    throw new Exception("Stack empty");
                stackTop--;
                return items[stackTop];
            }
        }
        static void Main(string[] args)
        {
            MyStack<string> nameStack = new MyStack<string>();
            nameStack.Push("Rob");
            nameStack.Push("Mary");
            Console.WriteLine(nameStack.Pop());
            Console.WriteLine(nameStack.Pop());
            Console.ReadKey();
        }
    }
}

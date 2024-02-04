using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class SimpleClass
    {
        public static void oneToTen()
        {
            Console.WriteLine("Thread id : " + Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 10; i++) { Console.WriteLine("SimpleClass : "+i); }
        }

        public static void printVar(object a)
        {
            Console.WriteLine("SimpleClass : " + a);
        }

        public static void print(int a)
        {
            Console.WriteLine("SimpleClass : " + a);
        }

               


    }
}

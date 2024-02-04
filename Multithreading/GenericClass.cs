using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class GenericClass<T>
    {

        public static void oneToTen()
        {
            Console.WriteLine("Thread id : "+Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 10; i++) { Console.WriteLine("GenericClass : "+i); }
        }

        public static void printVar(object a)
        {
            Console.WriteLine("GenericClass : " + a);
        }

        public static void print(List<T> a)
        {
            Console.WriteLine("Thread id : " + Thread.CurrentThread.ManagedThreadId);
            foreach (T e in a) Console.WriteLine("GenericClass : "+e);
        }
    }
}

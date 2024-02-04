using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class SharedResource
    {

        private static int sharedvar = 0;

        /*private static bool isCompleted = false;

        private readonly static Object obj = new object();*/

        public static void ExecuteIfNot()
        {
            Console.WriteLine($"Waiting Thread Id : {Thread.CurrentThread.ManagedThreadId}");

            /*lock (obj)
            {

                if (!isCompleted)
                {*/

                    Console.WriteLine($"Function executed once by {Thread.CurrentThread.ManagedThreadId}");

/*                    isCompleted = true;

                }
            }*/

}
        public static void Main(string[] args)
        {

            /*Thread t = new Thread(ExecuteIfNot);

            t.Start();

            ExecuteIfNot();*/
            /*List<Task<String>> tasks = new List<Task<String>>();

            for (int i = 0; i < 5; i++)
            {
                tasks.Add(Task.Factory.StartNew(() => "Hello " + Thread.CurrentThread.Name));
            }

            Task tAll = Task.WhenAll(tasks).ContinueWith(x => Console.WriteLine("Completed All ! "));
            Task tAny = Task.WhenAny(tasks).ContinueWith(x => Console.WriteLine("Completed Some thread !"));*/

           
        }

    }
}

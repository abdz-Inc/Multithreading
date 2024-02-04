// See https://aka.ms/new-console-template for more information
using Multithreading;
using System.Reflection.Metadata.Ecma335;

// Two ways of init -> ThreadStart & ParameterizedThreadStart

// ThreadStart              -> 
/*public delegate void ThreadStart();

public delegate void ParameterizedThreadStart(object? obj);*/
/*
Thread t = new Thread(SimpleClass.oneToTen);
t.Start();*/


// ParameterisedThreadStart -> 

/*Thread t1 = new Thread(SimpleClass.printVar);
t1.Start(10);*/


// Assign params to calling function


/*Thread t2 = new Thread();
t2.Start();*/


//  ThreadPool Class        -> Used to create a threadPool -> reduces overhead on creating & destroying individual threads

//                          -> MinNumThreads Should be equal or greater than core in machine -> Environment.ProcessorCount

//                          -> Queues method for exec using the QueueUserWorkItem which accepts a WaitCallBack fn

//                          ->     

//  public static bool QueueUserWorkItem (System.Threading.WaitCallback callBack);



/*ThreadPool.QueueUserWorkItem(
    (obj) => SimpleClass.printVar(obj)
    );*/

//  public static bool QueueUserWorkItem (System.Threading.WaitCallback callBack, object? state);


/*ThreadPool.QueueUserWorkItem(
    SimpleClass.printVar, "hello"
);*/

// 


// TASK -- creates bg threads


// Task(Action)

/*Task t = new Task(() => Console.WriteLine("hello"));
t.Start();
t.Wait();


// StartNew(Action)

Task<String> ts = Task<string>.Factory.StartNew(() => "hello");


// Task(Action<Object>, Object)

Task tparam = new Task((obj) => Console.WriteLine(obj), "Input param");
tparam.Start();
*/


// Chaining Tasks Using ContinueWith

/*List<Task<string>> tasks = new List<Task<string>>();

for (int i = 0; i < 5; i++)
{
    tasks.Add(Task.Factory.StartNew(() => "Hello " + Thread.CurrentThread.ManagedThreadId));
}


Task tAll = Task.WhenAll(tasks).ContinueWith(x => Console.WriteLine("Completed All ! "));
Task tAny = Task.WhenAny(tasks).ContinueWith(x => Console.WriteLine("Completed Some thread !")); // TaskContinuationOptions.NotOnRanToCompletion);
*/


/*for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Main " + i);
    //Thread.Sleep(1);
}
*/


Console.ReadKey();
using System;
using System.Threading;

namespace JoinAndSleep
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread (Go);
            t.Start();
            t.Join();
            Console.WriteLine ("Thread t has ended!");
            void Go() { for (int i = 0; i < 1000; i++) Console.Write ("y"); }

            
            //Thread.Sleep pauses the current thread for a specified period:
            Thread.Sleep (TimeSpan.FromHours (1)); // Sleep for 1 hour
            Thread.Sleep (500); // Sleep for 500 milliseconds
        }
        // This prints “y” 1,000 times, followed by “Thread t has ended!” immediately afterward.
        // You can include a timeout when calling Join, either in milliseconds or as a TimeSpan.
        // //It then returns true if the thread ended or false if it timed out.
        
        
    }
}
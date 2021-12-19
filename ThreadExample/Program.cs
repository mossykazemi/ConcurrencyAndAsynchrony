using System;
using System.Threading;

namespace ThreadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY);  //created new Thread here
            t.Start(); //run the thread
            Console.WriteLine (Thread.CurrentThread.Name);
            // Simultaneously, do something on the main thread.
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");
            }

            void WriteY()
            {
                Console.WriteLine (Thread.CurrentThread.Name);
                for (int i = 0; i < 1000; i++)
                {
                    Console.Write("Y");
                }
            }
            //in this example x and y write on the console at the same time (Simultaneously)
        }
    }
}
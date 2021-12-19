using System;
using System.Threading;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     new Thread(Go).Start();
            // }
            // catch (Exception ex)
            // {
            //     //we'll never get here!
            //     Console.WriteLine("Exception!");
            // }
            //
            // void Go()
            // {
            //     throw null;
            // }

            // The try/catch statement in this example is ineffective, and the newly created thread
            //will be encumbered with an unhandled NullReferenceException. This behavior
            // makes sense when you consider that each thread has an independent execution path.

            new Thread(Go).Start();

            void Go()
            {
                try
                {
                    throw null; // The NullReferenceException will get caught below
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    // Typically log the exception, and/or signal another thread
                    // that we've come unstuck
                }
            }
        }
    }
}
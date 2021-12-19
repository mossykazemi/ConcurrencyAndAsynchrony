using System;
using System.Threading;

namespace LocalVersusSharedState
{
    class Program
    {
        #region Local

        // static void Main(string[] args)
        // {
        //     new Thread (Go).Start(); // Call Go() on a new thread
        //     Go(); // Call Go() on the main thread
        //     void Go()
        //     {
        //         // Declare and use a local variable - 'cycles'
        //         for (int cycles = 0; cycles < 5; cycles++) Console.Write ('?');
        //     }
        //    // A separate copy of the cycles variable is created on each thread’s memory stack,
        //    // and so the output is, predictably, 10 question marks.
        // }

        #endregion

        #region SharedState

        // static void Main(string[] args)
        // {
        //     bool _done = false;
        //     new Thread(Go).Start();
        //     Go();
        //
        //     void Go()
        //     {
        //         if (!_done)
        //         {
        //             _done = true;
        //             Console.WriteLine("Done");
        //         }
        //     }
        // }

        //Both threads share the _done variable, so “Done” is printed once instead of twice.

        #endregion

        #region Lambda

        // static void Main(string[] args)
        // {
        //     bool done = false;
        //     ThreadStart action = () =>
        //     {
        //         if (!done)
        //         {
        //             done = true;
        //             Console.WriteLine("Done");
        //         }
        //     };
        //     new Thread(action).Start();
        //     action();
        // }

        #endregion

        #region Shared Fields

        // More commonly, though, fields are used to share data between threads. In the fol‐
        // lowing example, both threads call Go() on the same ThreadTest instance, so they
        // share the same _done field:

        // static void Main(string[] args)
        // {
        //     var tt = new ThreadTest();
        //     new Thread(tt.Go).Start();
        //     tt.Go();
        // }
        //
        // class ThreadTest
        // {
        //     bool _done;
        //
        //     public void Go()
        //     {
        //         if (!_done)
        //         {
        //             _done = true;
        //             Console.WriteLine("Done");
        //         }
        //     }
        // }

        #endregion

        #region Static Fields

        //Static fields offer another way to share data between threads:
        class ThreadTest
        {
            static bool _done; // Static fields are shared between all threads

            // in the same process.
            static void Main()
            {
                new Thread(Go).Start();
                Go();
            }

            static void Go()
            {
                if (!_done)
                {
                    _done = true;
                    Console.WriteLine("Done");
                }
            }
        }

        #endregion
    }
}
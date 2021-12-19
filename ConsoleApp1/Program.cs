using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread (Go).Start(); // Call Go() on a new thread
            Go(); // Call Go() on the main thread
            void Go()
            {
                // Declare and use a local variable - 'cycles'
                for (int cycles = 0; cycles < 5; cycles++) Console.Write ('?');
            }
        }
    }
}
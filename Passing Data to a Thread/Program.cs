using System;
using System.Threading;

namespace Passing_Data_to_a_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sometimes, you’ll want to pass arguments to the thread’s startup method. The easi‐
            // est way to do this is with a lambda expression that calls the method with the desired
            // arguments:

            Thread t = new Thread(() => Print("Hello from t!"));
            t.Start();

            void Print(string message) => Console.WriteLine(message);

            //With this approach, you can pass in any number of arguments to the method.
            //You can even wrap the entire implementation in a multistatement lambda:
            new Thread(() =>
            {
                Console.WriteLine("I'm running on another thread!");
                Console.WriteLine("This is so easy!");
            }).Start();

            //An alternative (and less flexible) technique is to pass an argument into Thread’s
            //Start method:
            Thread tt = new Thread(Printt);
            tt.Start("Hello from tt!");

            void Printt(object messageObj)
            {
                string message = (string) messageObj; // We need to cast here
                Console.WriteLine(message);
            }
            //This works because Thread’s constructor is overloaded to accept either of two delegates:
            //public delegate void ThreadStart();
            //public delegate void ParameterizedThreadStart (object obj);
        }
    }
}
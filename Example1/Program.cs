using System;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.Write(" Method 2");
                // Do something
                Task.Delay(100).Wait();
            }
        }
    }
}
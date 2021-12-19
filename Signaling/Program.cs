using System;
using System.Threading;

namespace Signaling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sometimes, you need a thread to wait until receiving notification(s) from other
            //thread(s). This is called signaling. The simplest signaling construct is ManualReset
            //Event. Calling WaitOne on a ManualResetEvent blocks the current thread until
            //another thread “opens” the signal by calling Set. In the following example, we start
            //up a thread that waits on a ManualResetEvent. It remains blocked for two seconds
            //until the main thread signals it:
            var signal = new ManualResetEvent(false);
            new Thread(() =>
            {
                Console.WriteLine("Waiting for signal...");
                signal.WaitOne();
                signal.Dispose();
                Console.WriteLine("Got signal!");
            }).Start();
            Thread.Sleep(2000);
            signal.Set(); // “Open” the signal
            
            // After calling Set, the signal remains open; You can close it again by calling Reset.
        }
    }
}
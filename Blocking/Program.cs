using System;
using System.Diagnostics;

namespace Blocking
{
    class Program
    {
        static void Main(string[] args)
        {
            // You can test for a thread being blocked via its ThreadState property:
            //bool blocked = (someThread.ThreadState & ThreadState.WaitSleepJoin) != 0;

        }
       
    }
    //extention method 
    // public static ThreadState Simplify(this ThreadState ts)
    // {
    //     return ts & (ThreadState.Unstarted |
    //                  ThreadState.WaitSleepJoin |
    //                  ThreadState.Stopped);
    // }
}
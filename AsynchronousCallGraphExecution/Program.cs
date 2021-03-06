using System;
using System.Threading.Tasks;

namespace AsynchronousCallGraphExecution
{
    class Program
    {
        static void Main(string[] args)
        {
            async Task Go()
            {
                var task = PrintAnswerToLife();
                await task;
                Console.WriteLine("Done");
            }

            async Task PrintAnswerToLife()
            {
                var task = GetAnswerToLife();
                int answer = await task;
                Console.WriteLine(answer);
            }

            async Task<int> GetAnswerToLife()
            {
                var task = Task.Delay(5000);
                await task;
                int answer = 21 * 2;
                return answer;
            }
        }
    }
}
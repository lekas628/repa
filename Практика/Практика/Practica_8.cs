using System;
using System.Threading;

namespace Practicum_8_1
{
    class task_1
    {
        public static void run()
        {
            ThreadStart starter = new ThreadStart(Counting);
            Thread first = new Thread(starter);
            Thread second = new Thread(starter);

            first.Start();
            second.Start();

            first.Join();
            second.Join();
        } 

        static void Counting()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Count: {0} - Thread' {1}", 1, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(10);
            }
        }
    }
}
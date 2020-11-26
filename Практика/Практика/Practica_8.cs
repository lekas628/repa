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

namespace Practicum_8_2
{
     class task_1
    {
        public static void run()
        {

            Mutex oneMutex = null;
            const String MutexName = "RUNMEONLYONCE";
            try 
            {
                oneMutex = Mutex.OpenExisting(MutexName);

            }
            catch (WaitHandleCannotBeOpenedException)
            {
                Console.WriteLine("cant find Mutex because it not exist");
            }
            if(oneMutex == null)
            {
                oneMutex = new Mutex(true, MutexName);
            }
            else
            {
                oneMutex.Close();
                return;
            }
            Console.WriteLine("Our Appication");
            // Console.Read();
        }
    }
}

namespace Practicum_8_3
{
     class task_1
    {
        public static void run()
        {
            WaitCallback callback = new WaitCallback(ShowMyText);
            ThreadPool.QueueUserWorkItem(callback, "Hello");
            ThreadPool.QueueUserWorkItem(callback, "Hi");
            ThreadPool.QueueUserWorkItem(callback, "Heya");
            ThreadPool.QueueUserWorkItem(callback, "Goodbye");
            // Console.Read();
        }

        static void ShowMyText(object state)
        {
            string myText = (string)state;
            Console.WriteLine("Thread: {0} - {1}",
                Thread.CurrentThread.ManagedThreadId, myText);
        }
    }
}
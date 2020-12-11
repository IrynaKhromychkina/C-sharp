using System;
using System.Threading;

namespace ManagingThreads
{
    class Program
    {
        static int counter;
        static object block = new object();

        static void ShowCounter()
        {
            lock (block)
            {
                for (int i = 0; i < 10; i++)
                {
                    counter++;
                    Console.WriteLine($"Thread {Thread.CurrentThread.GetHashCode()} is working. Counter = {counter}");
                }
                Console.WriteLine($"Thread {Thread.CurrentThread.GetHashCode()} has finished its work\n");
            }
        }
        static void Main(string[] args)
        {
            int threadsQuantity = 3;
            Thread[] threads = new Thread[threadsQuantity];
            for (int i = 0; i < threadsQuantity; i++)
            {
                threads[i] = new Thread(ShowCounter);
                threads[i].Start();
            }

            Console.ReadKey();
        }
    }
}

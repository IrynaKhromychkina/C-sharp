using System;
using System.Threading;
using System.Threading.Tasks;

namespace TwoParallelMethods
{
    class Program
    {
        static void FirstTask()
        {
            Thread.Sleep(3000);
            Console.WriteLine($"Parallel method FirstTask. Thread: {Thread.CurrentThread.ManagedThreadId}");
        }
        static void SecondTask()
        {
            Thread.Sleep(2000);
            Console.WriteLine($"Parallel method SecondTask. Thread: {Thread.CurrentThread.ManagedThreadId}");
        }
        static void Main(string[] args)
        {
            Task firstTask = Task.Factory.StartNew(FirstTask);
            Task secondTask = Task.Factory.StartNew(SecondTask);

            Console.WriteLine($"Main method finished working. Thread: {Thread.CurrentThread.ManagedThreadId}");

            Console.ReadKey();
        }
    }
}

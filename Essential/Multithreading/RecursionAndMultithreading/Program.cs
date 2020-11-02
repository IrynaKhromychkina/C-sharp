using System;
using System.Threading;

namespace RecursionAndMultithreading
{
    class Program
    {
        static int threadNumber = 1;
        static Random rnd = new Random();
        static void RecursionMethod()
        {
            Console.WriteLine($"RecursionMethod in action. Thread mumber: {threadNumber}");

            Thread thread = new Thread(RecursionMethod);
            threadNumber++;
            thread.Name = threadNumber.ToString();
            thread.IsBackground = true;
            thread.Start();
        }
        static void Main(string[] args)
        {
            RecursionMethod();

            Console.ReadKey();
        }
    }
}

using System;
using System.Diagnostics;
using System.Linq;

namespace UsingPLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            byte [] array = new byte [1000000000];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (byte)random.Next(0, 100);
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            ParallelQuery <byte> numbers = from number in array.AsParallel()
                                         where (number % 2) == 1
                                         select number;

            int count = numbers.Count();

            stopwatch.Stop();

            //foreach (int number in numbers)
            //    Console.Write(number + " ");

            Console.WriteLine($"PLINQ has been working for {stopwatch.ElapsedMilliseconds} ms and it found {count} odd numbers");

            Console.ReadKey();
        }
    }
}

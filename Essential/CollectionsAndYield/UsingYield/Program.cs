using System;
using System.Collections.Generic;

namespace UsingYield
{
    class Program
    {
        static IEnumerable<int> FilterEvenNumbers(int[] array)
        {
            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    yield return item;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] myArray = { 35, 228, 12, 3, 9, 19, 29, 32 };

            foreach (int element in Program.FilterEvenNumbers(myArray))
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}

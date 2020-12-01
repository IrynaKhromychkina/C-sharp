using System;
using System.Collections.Generic;

namespace UsingYield
{
    class Program
    {
        public static IEnumerable<double> Power(int[] integers)
        {
            double power = 2;
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 1)
                {
                    yield return Math.Pow(integers[i], power);
                }
            }
        }

        static void Main(string[] args)
        {
            int[] integers = { 3, 5, 6, 8, 12, 1 };

            IEnumerable<double> poweredIntegers = Power(integers);

            foreach (int integer in poweredIntegers)
            {
                Console.WriteLine(integer.ToString());
            }

            Console.ReadKey();
        }
    }
}

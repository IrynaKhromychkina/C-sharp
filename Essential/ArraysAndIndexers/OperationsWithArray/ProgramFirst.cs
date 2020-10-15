using System;

namespace OperationsWithArray
{
    partial class Program
    {
        static void Main(string[] args)
        {
            const int n = 9;

            byte[] myArray = new byte[n];
            FillArray(myArray);

            ShowArray(myArray);

            byte minResult = MinValue(myArray);
            Console.WriteLine($"Min result is {minResult}");

            byte maxResult = MaxValue(myArray);
            Console.WriteLine($"Max result is {maxResult}");

            int sum = Sum(myArray);
            Console.WriteLine($"Sum equals to {sum}");

            double average = sum / n;
            Console.WriteLine($"Average equals to {average}");

            byte[] oddNumbers = OddNumbersMethod(myArray);
            Console.WriteLine("Odd numbers: ");
            ShowArray(oddNumbers);

            Console.ReadKey();
        }
    }
}

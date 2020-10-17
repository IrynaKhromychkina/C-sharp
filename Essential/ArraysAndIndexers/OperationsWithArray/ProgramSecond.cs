using System;

namespace OperationsWithArray
{
    partial class Program
    {
        static byte[] FillArray(byte[] myArray)
        {
            Random random = new Random();
            random.NextBytes(myArray);
            return myArray;
        }

        static void ShowArray(byte[] myArray)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]} ");
            }
            Console.WriteLine(" ");
        }

        static byte MinValue(byte[] array)
        {
            byte min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        static byte MaxValue(byte[] array)
        {
            byte max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static int Sum(byte[] array)
        {
            int sum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }

        static byte[] OddNumbersMethod(byte[] array)
        {
            int oddNumberCount = GetOddNumbersCount(array);
            byte[] oddValues = new byte[oddNumberCount];
            int oddNumbersIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    oddValues[oddNumbersIndex] = array[i];
                    oddNumbersIndex++;
                }
            }
            return oddValues;
        }

        private static int GetOddNumbersCount(byte[] array)
        {
            int oddNumberCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    oddNumberCount++;
                }
            }

            return oddNumberCount;
        }
    }
}

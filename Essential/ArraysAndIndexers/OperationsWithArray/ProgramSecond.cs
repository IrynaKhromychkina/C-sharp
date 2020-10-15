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
            int remainder;
            int count1 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                remainder = array[i] % 2;

                if (remainder == 1)
                {
                    count1++;
                }
            }

            byte[] oddValues = new byte[count1];
            int count2 = 0;

            for (int i = 0; i < array.Length; i++)
            {
                remainder = array[i] % 2;

                if (remainder == 1)
                {
                    oddValues[count2] = array[i];
                    count2++;
                }
            }
            return oddValues;
        }
    }
}

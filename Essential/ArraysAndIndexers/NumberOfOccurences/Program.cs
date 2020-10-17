using System;

namespace NumberOfOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sample = { 1, 2, 2, 3, 3, 3, 4, 4, 5, 5, 5, 5, 6 };
            int number = 5;

            int numOfOcc = NumOfOcc(sample, number);

            Console.WriteLine($"Number of occurences is {numOfOcc}");

            Console.ReadKey();
        }
        public static int NumOfOcc(int[] sample, int number)
        {
            int count = 0;
           
            for (int i = 0; i < sample.Length; count += (sample[i++] == number) ? 1 : 0);
           
            return count;
        }
    }
}

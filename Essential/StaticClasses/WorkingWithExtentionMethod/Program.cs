using System;

namespace WorkingWithExtentionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 78, 0, 7, 45, 86, 34, 0, 4, 12 };

            int[] newArray = myArray.SortArray();
            newArray.Show();

            Console.ReadKey();
        }
    }
}

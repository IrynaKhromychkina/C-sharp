using System;

namespace WorkingWithExtentionMethod
{
    public static class OperationsWithArray
    {
        public static int[] SortArray(this int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        public static void Show(this int[] array)
        {
            for (int k = 0; k < array.Length; k++)
            {
                Console.Write($"{array[k]} ");
            }
        }
    }
}

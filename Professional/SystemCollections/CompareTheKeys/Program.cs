using System;
using System.Collections.Specialized;

namespace CompareTheKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            CompareStringKeys comparer = new CompareStringKeys();
            var orderedDictionary = new OrderedDictionary(comparer);

            orderedDictionary.Add("Key1", "Value1");
            orderedDictionary.Add("Key2", "Value2");
            try
            {
                orderedDictionary.Add("Key1", "Value3");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Items in the ordered dictionary: {orderedDictionary.Count}");

            Console.ReadKey();
        }
    }
}

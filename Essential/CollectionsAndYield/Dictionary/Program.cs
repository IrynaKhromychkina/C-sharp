using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyDictionary<int, string> myNumbers = new MyDictionary<int, string>(2);
            myNumbers.Add(1, "one");
            myNumbers.Add(2, "two");
            myNumbers.Add(3, "three");

            Console.WriteLine($"My dictionary contains {myNumbers.Count} elements");

            Console.WriteLine($"Second item is '{myNumbers[1]}'");
            Console.WriteLine($"Fourth item is '{myNumbers[3]}'");

            foreach (KeyValuePair<int, string> element in myNumbers)
            {
                Console.WriteLine($"{element.Key} - {element.Value}");
            }

            Console.ReadKey();
        }
    }
}


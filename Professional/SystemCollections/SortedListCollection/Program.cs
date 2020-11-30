using System;
using System.Collections;

namespace SortedListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesList = new SortedList();
            namesList["Steve"] = "Jobs";
            namesList["Tim"] = "Berners-Lee";
            namesList["Bill"] = "Gates";
            namesList["James"] = "Gosling";

            foreach(DictionaryEntry entry in namesList)
            {
                Console.WriteLine($"{entry.Key} {entry.Value}");
            }

            Console.ReadKey();
        }
    }
}

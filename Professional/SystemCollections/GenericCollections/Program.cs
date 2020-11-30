using System;
using System.Collections.Generic;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataBaseList = new List<KeyValuePair<int, double>>();

            dataBaseList.Add(new KeyValuePair<int, double>(10801000, 15826.5));
            dataBaseList.Add(new KeyValuePair<int, double>(35280815, 1830.6));
            dataBaseList.Add(new KeyValuePair<int, double>(32920720, 47606.5));

            Console.WriteLine("List:");
           
            dataBaseList.ForEach(kv => Console.WriteLine($"{kv.Key} - {kv.Value}"));

            var dataBaseDictionary = new Dictionary<int, double>();
            dataBaseDictionary[10801000] = 15826.5;
            dataBaseDictionary[25966527] = 581.78;
            dataBaseDictionary[65930568] = 8875.7;

            Console.WriteLine("Dictionary:");

            foreach (var kv in dataBaseDictionary)
            {
                Console.WriteLine($"{kv.Key} - {kv.Value}");
            }

            Console.ReadKey();
        }
    }
}

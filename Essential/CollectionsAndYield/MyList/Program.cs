using System;

namespace MyList
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyList<string> myStrings = new MyList<string>(10);
            myStrings.Add("first");
            myStrings.Add("second");

            Console.WriteLine($"My list contains {myStrings.Count} items");
            Console.WriteLine($"Second item is - '{myStrings[1]}'");
            Console.WriteLine($"Fifth item is - '{myStrings[5]}'");

            Console.WriteLine(new string('-', 30));

            string[] myStringsArray = myStrings.GetArray();

            foreach (string element in myStringsArray)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(new string('-', 30));
            string[] newStringArray = myStrings.GetArray<string>();

            foreach (string element in newStringArray)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}

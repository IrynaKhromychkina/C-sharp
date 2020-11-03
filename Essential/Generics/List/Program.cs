using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myStrings = new MyList<string>(10);
            myStrings.Add("first");
            myStrings.Add("second");

            Console.WriteLine($"My list contains {myStrings.Count} items");
            Console.WriteLine($"Second item is - '{myStrings[1]}'");
            Console.WriteLine($"Fifth item is - '{myStrings[5]}'");

            Console.WriteLine(new string('-', 30));

            string[] myStringsArray = myStrings.GetArray();

            for (int i = 0; i < myStringsArray.Length; i++)
            {
                Console.WriteLine(myStringsArray[i]);
            }
            Console.ReadKey();
        }
    }
}

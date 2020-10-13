using System;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["book"]);
            Console.WriteLine(dictionary["house"]);
            Console.WriteLine(dictionary["pen"]);
            Console.WriteLine(dictionary["стiл"]);
            Console.WriteLine(dictionary["pencil"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["sun"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.ReadKey();
        }
    }
}

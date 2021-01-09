using System;
using System.IO;
using System.Text.RegularExpressions;

namespace FindAndReplace
{
    class Program
    {
        static void Main(string[] args)
        {

            const string prepositionPattern = @"\s[a-zA-Z]{1,3}\s";
     
            if (!File.Exists("Test.txt"))
            {
                Console.WriteLine("File does not exist");
                Console.ReadKey();
                return;
            }

            string content = File.ReadAllText("Test.txt");
            string contentAmended;
            contentAmended = Regex.Replace(content, prepositionPattern, " PREPOSITION ");

            File.WriteAllText("Test.txt", contentAmended);

            Console.WriteLine("Done");

            Console.ReadKey();
        }
    }
}

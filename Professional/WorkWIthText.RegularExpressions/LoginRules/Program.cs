using System;
using System.Text.RegularExpressions;

namespace LoginRules
{
    class Program
    {
        static void Main(string[] args)
        {
            const string loginPattern = @"^[a-zA-Z]+$";
            const string passwordPattern = @"^[a-zA-Z0-9]+$";

            var regexLogin = new Regex(loginPattern);
            var regexPassword = new Regex(passwordPattern);


            Console.WriteLine("Please enter login (latin letters only)");
            string inputLogin = Console.ReadLine();

            Console.WriteLine(regexLogin.IsMatch(inputLogin)
                        ? $"Login entered - {inputLogin} accepted"
                        : $"Login entered - {inputLogin} CAN NOT be accepted. Please use latin letters only");

            Console.WriteLine("");

            Console.WriteLine("Please enter password (latin letters and numbers only)");
            string inputPassword = Console.ReadLine();

            Console.WriteLine(regexPassword.IsMatch(inputPassword)
                        ? $"Login entered - {inputPassword} accepted"
                        : $"Login entered - {inputPassword} CAN NOT be accepted. Please use latin letters only");

            Console.ReadKey();
        }
    }
}

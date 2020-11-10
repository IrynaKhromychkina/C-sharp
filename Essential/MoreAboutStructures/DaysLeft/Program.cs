using System;

namespace DaysLeft
{

    class Program
    {
        public static DateTime InputMethod()
        {
            DateTime birthDate = new DateTime();
            bool isRunning1 = true;

            while (isRunning1)
            {
                Console.WriteLine($"Please enter the date and month of your birthday in the following format: MM DD");
                string birthDateStr = Console.ReadLine().Trim();

                if (DateTime.TryParse(birthDateStr, out birthDate))
                {
                    return birthDate;
                }
                else
                {
                    Console.WriteLine("Wrong input. Please repeat\n");
                    continue;
                }
            }
            return birthDate;
        }

        static void Main(string[] args)
        {
            DateTime birthDate = InputMethod();
            DateTime today = DateTime.Today;

            if (birthDate.Month < today.Month)
            {
                if (birthDate.Month == 02 && birthDate.Day == 29)
                {
                    DateTime yourNextBD = new DateTime(today.Year + 4, birthDate.Month, birthDate.Day);
                    TimeSpan left = yourNextBD - today;
                    Console.WriteLine($"{left.Days} day(s) left to you next birthday");
                }
                else
                {
                    DateTime yourNextBD = new DateTime(today.Year + 1, birthDate.Month, birthDate.Day);
                    TimeSpan left = yourNextBD - today;
                    Console.WriteLine($"{left.Days} day(s) left to you next birthday");
                }
            }
            if (birthDate.Month > today.Month)
            {
                TimeSpan left = birthDate - today;
                Console.WriteLine($"{left.Days} day(s) left to you next birthday");
            }
            if (birthDate.Month == today.Month)
            {
                if (birthDate.Day < today.Day)
                {
                    DateTime yourNextBD = new DateTime(today.Year + 1, birthDate.Month, birthDate.Day);
                    TimeSpan left = yourNextBD - today;
                    Console.WriteLine($"{left.Days} day(s) left to you next birthday");
                }
                if (birthDate.Day > today.Day)
                {
                    TimeSpan left = birthDate - today;
                    Console.WriteLine($"{left.Days} day(s) left to you next birthday");
                }
                if (birthDate.Day == today.Day)
                {
                    Console.WriteLine("You birthday is today! Congratulations!");
                }
            }

            Console.ReadKey();
        }
    }
}

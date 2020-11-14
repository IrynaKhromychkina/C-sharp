using System;

namespace LetsChangeDates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myBD = new DateTime(2021, 05, 29);
            int week = 7;

            Date today = new Date(DateTime.Today);
            Date myNextBD = new Date(myBD);

            double daysLeft = myNextBD - today;

            Date datePlusWeek = today + week;

            Console.WriteLine($"{daysLeft} days left to my next birthday");

            Console.WriteLine($"The date same day next week will be {datePlusWeek.DateTime.ToShortDateString()}");

            Console.ReadKey();
        }
    }
}

using System;

namespace MonthsCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            MonthsCollection months = new MonthsCollection();

            months[0] = new Month("January", 1, 31);
            months[1] = new Month("February", 2, 29);
            months[2] = new Month("March", 3, 31);
            months[3] = new Month("April", 4, 30);
            months[4] = new Month("May", 5, 31);
            months[5] = new Month("June", 6, 30);
            months[6] = new Month("July", 7, 31);
            months[7] = new Month("August", 8, 31);
            months[8] = new Month("September", 9, 30);
            months[9] = new Month("October", 10, 31);
            months[10] = new Month("November", 11, 30);
            months[11] = new Month("December", 12, 31);

            byte requestNumber = 12;
            byte requestDays = 30;

            Console.WriteLine("Month by requested number:\n");
            
            foreach (Month month in months)
            {
                if (month.Number == requestNumber)
                {
                    Console.WriteLine($"Name: {month.Name} Number: {month.Number} Days: {month.Days}");
                }
            }

            Console.WriteLine("\nMonth(s) by requested days:\n");

            foreach (Month month in months)
            {
                if (month.Days == requestDays)
                {
                    Console.WriteLine($"Name: {month.Name} Number: {month.Number} Days: {month.Days}");
                }
            }

            Console.ReadKey();
        }
    }
}

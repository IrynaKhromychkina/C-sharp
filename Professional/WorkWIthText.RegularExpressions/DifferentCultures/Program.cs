using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace DifferentCultures
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            CultureInfo russianCulture = new CultureInfo("ru-RU");
            using (var stream = new FileStream("Test.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine("Milk - 8,67 - 05/12/2020");
                    writer.WriteLine("Bread - 3 - 12/12/2020");
                    writer.WriteLine("Cheese - 15 - 04/12/2020");
                }
            }

            string[] contentLines = File.ReadAllLines("Test.txt");
  
            List<string> contentElements = new List<string>();

            for (int i = 0; i < contentLines.Length; i++)
            {
                string[] elements = contentLines[i].Split('-');

                for (int j = 0; j < elements.Length; j++)
                {
                    contentElements.Add(elements[j]);
                }
            }

            List<Double> priceElementsCurrent = new List<Double>();
            List<DateTime> dateElementsCurrent = new List<DateTime>();
           
            Console.WriteLine("Info in current culture");

            for (int i = 1; i <= contentElements.Count; i = i + 3)
            {

                priceElementsCurrent.Add(Double.Parse(contentElements[i], currentCulture));
                dateElementsCurrent.Add(DateTime.Parse(contentElements[i + 1], currentCulture));
            }

            int count = 0;

            for (int i = 0; i < priceElementsCurrent.Count; i++)
            {
                Console.WriteLine(contentElements[count] + " " + priceElementsCurrent[i] + " " + dateElementsCurrent[i]);
                count = count + 3;
            }

            List<Double> priceElementsRU = new List<Double>();
            List<DateTime> dateElementsRU = new List<DateTime>();

            Console.WriteLine("\nInfo in ru-RU culture");

            for (int i = 1; i <= contentElements.Count; i = i + 3)
            {

                priceElementsRU.Add(Double.Parse(contentElements[i], russianCulture));
                dateElementsRU.Add(DateTime.Parse(contentElements[i + 1], russianCulture));
            }

            int counter = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(contentElements[counter] + " " + priceElementsRU[i] + " " + dateElementsRU[i]);
                counter = counter + 3;
            }

            Console.ReadKey();
        }
    }
}

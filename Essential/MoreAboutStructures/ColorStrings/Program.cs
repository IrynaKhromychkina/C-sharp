using System;

namespace ColorStrings
{
    class Program
    {
        public static int InputMethod()
        {
            int colorInt = 0;
            bool isRunning1 = true;

            while (isRunning1)
            {
                Console.WriteLine("Please enter the number of color:\n0 - Red\n1 - Yellow\n2 - Blue\n3 - Magenta");
                string colorStr = Console.ReadLine().Trim();
                Array colors = Enum.GetValues(typeof(Colors));

                if (Int32.TryParse(colorStr, out colorInt) && colorInt < colors.Length && colorInt >= 0)
                {
                    return colorInt;
                }
                else
                {
                    Console.WriteLine("Wrong input. Please repeat\n");
                    continue;
                }
            }
            return colorInt;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string to print");
            string stringToPrint = Console.ReadLine().Trim();
            int color = InputMethod();

            ColorPrinter.Print(stringToPrint, color);
            
            Console.ReadKey();
        }
    }
}

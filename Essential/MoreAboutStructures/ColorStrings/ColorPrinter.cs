using System;

namespace ColorStrings
{
    static class ColorPrinter
    {
        public static void Print(string stringToPrint, int color)
        {
            ConsoleColor outputColor = color
                .IntToColorsConverter()
                .ColorsToConsoleColorConverter();

            Console.ForegroundColor = outputColor;
            Console.WriteLine(stringToPrint);
            Console.ResetColor();
        }
    }
}

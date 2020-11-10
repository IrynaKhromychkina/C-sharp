using System;

namespace ColorStrings
{
    static class ColorConverter
    {
        public static Colors IntToColorsConverter(this int color) => (Colors)Enum.GetValues(typeof(Colors)).GetValue(color);

        public static ConsoleColor ColorsToConsoleColorConverter(this Colors inputColor)
        {
            switch (inputColor)
            {
                case Colors.Red:
                    return ConsoleColor.Red;
                case Colors.Blue:
                    return ConsoleColor.Blue;
                case Colors.Yellow:
                    return ConsoleColor.Yellow;
                case Colors.Magenta:
                    return ConsoleColor.Magenta;
                default:
                    return ConsoleColor.White;
            }
        }
    }
}

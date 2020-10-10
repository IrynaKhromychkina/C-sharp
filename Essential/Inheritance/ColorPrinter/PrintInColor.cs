using System;

namespace ColorPrinter
{
    class PrintInColor : Printer
    {
        private string typeColor;

        public PrintInColor(string color)
        {
            typeColor = color;
        }

        public override void Print (string color)
        {
            ConsoleColor outputColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), typeColor);
            Console.ForegroundColor = outputColor;
            base.Print(color);
            Console.ResetColor();
        }
    }
}

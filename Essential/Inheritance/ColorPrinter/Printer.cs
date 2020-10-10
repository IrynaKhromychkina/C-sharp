using System;

namespace ColorPrinter
{
    public class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}

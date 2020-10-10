using System;

namespace ColorPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInColor exampleColor = new PrintInColor("Red");
            exampleColor.Print("Hello from derived class");

            Printer examplePlain = exampleColor;
            examplePlain.Print("Hello from Base class");

            PrintInColor exampleColor1 = (PrintInColor)examplePlain;
            exampleColor1.Print("Hello from derived class");

            PrintInColor exampleColor2 = new PrintInColor("Blue");
            exampleColor2.Print("Hello from derived class");

            Console.ReadKey();
        }

    }
}

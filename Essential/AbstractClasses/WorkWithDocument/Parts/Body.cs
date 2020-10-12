using System;

namespace WorkWithDocument
{
    class Body : AbstractContent
    {
        public override void Show()
        {
            ConsoleColor previousColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = previousColor;
        }
    }
}

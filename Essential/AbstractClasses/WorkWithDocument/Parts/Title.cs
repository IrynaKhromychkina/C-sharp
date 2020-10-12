using System;

namespace WorkWithDocument
{
    class Title : AbstractContent
    {
        public override void Show()
        {
            ConsoleColor previousColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = previousColor;
        }
    }
}

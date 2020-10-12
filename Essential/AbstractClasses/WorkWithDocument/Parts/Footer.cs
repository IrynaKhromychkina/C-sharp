using System;

namespace WorkWithDocument
{
    class Footer : AbstractContent
    {
        public override void Show()
        {
            ConsoleColor previousColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Content);
            Console.ForegroundColor = previousColor;
        }
    }
}

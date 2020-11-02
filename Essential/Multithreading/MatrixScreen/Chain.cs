using System;
using System.Threading;

namespace MatrixScreen
{
    class Chain
    {
        int delay;
        Random random = new Random(DateTime.Now.Millisecond);

        int asciiCharacterStart = 65;
        int asciiCharacterEnd = 122;
        int screenHeight;
        static object WriteCharLocker = new object();

        public Chain(int screenHeight)
        {
            this.screenHeight = screenHeight;
            delay = random.Next(5, 200);
        }

        public void WordFall(int x, int lettersQuantity)
        {
            for (int i = 0; i < (screenHeight + lettersQuantity + 1); i++)
            {
                Thread.Sleep(delay);
                WriteWord(x, i, lettersQuantity, screenHeight);
                if ((i - lettersQuantity) < 0)
                {
                    continue;
                }
            }
        }
        public void WriteWord(int a, int b, int lettersQuantity, int screenHeight)
        {
            var x = a;
            var y = b;
            lock (WriteCharLocker)
            {
                WriteChar(ConsoleColor.White, x, y, null);

                if (lettersQuantity > 1)
                {
                    y--;
                    WriteChar(ConsoleColor.Green, x, y, null);

                    for (int j = 2; j < lettersQuantity; j++)
                    {
                        y--;
                        WriteChar(ConsoleColor.DarkGreen, x, y, null);
                    }
                }

                y--;
                WriteChar(ConsoleColor.Black, x, y, ' ');
            }
        }
        public char GetRandomChar() => (char)random.Next(asciiCharacterStart, asciiCharacterEnd);
        public void WriteChar(ConsoleColor color, int x, int y, char? ch)
        {
            if (y < 0 || y > screenHeight)
            {
                return;
            }
            else
            {
                Console.SetCursorPosition(x, y);
                Console.CursorTop = y;

                Console.ForegroundColor = color;
                if (ch == null)
                {
                    Console.WriteLine(GetRandomChar());
                }
                else
                {
                    Console.WriteLine(" ");
                }
            }
        }
    }
}

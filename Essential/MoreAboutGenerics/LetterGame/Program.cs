using System;

namespace LetterGame
{
    class Program
    {
        const int infoRowNumber = 1;
        const int outputRowNumber = 2;
        const int inputRowNumber = 3;

        static void Main(string[] args)
        {
            int lifes = 3;
            int score = 0;
            int levelTime = 5000;

            Console.WriteLine($"Let's play. You have {lifes} lifes and {score} score. Try to enter the correct letter as quickly as possible\n");

            Random random = new Random(DateTime.Now.Millisecond);

            bool showMustGoOn = true;

            while (showMustGoOn)
            {
                int num1 = random.Next(65, 91);
                int num2 = random.Next(97, 123);
                int myRandomNumber = random.Next(0, 2) == 1 ? num1 : num2;

                Console.SetCursorPosition(0, outputRowNumber);
                Console.WriteLine((char)myRandomNumber);
                DateTime outputTime = DateTime.Now;

                Console.SetCursorPosition(0, inputRowNumber);
                Console.WriteLine(" ");
                Console.SetCursorPosition(0, inputRowNumber);
                ConsoleKeyInfo inputLetter = Console.ReadKey();
                DateTime inputTime = DateTime.Now;

                TimeSpan span = inputTime - outputTime;

                if (inputLetter.KeyChar == (char)myRandomNumber && span.TotalMilliseconds <= levelTime)
                {
                    score += 100;
                    levelTime -= 250;
                    Console.SetCursorPosition(0, infoRowNumber);
                    Console.WriteLine($"Your score is {score} now! You have {lifes} lifes left\n");
                    continue;
                }
                else
                {
                    lifes -= 1;
                    Console.SetCursorPosition(0, infoRowNumber);
                    Console.WriteLine($"You have {lifes} lifes left                                \n");

                    if (lifes == 0)
                    {
                        Console.WriteLine("\t\tGAME OVER");
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}

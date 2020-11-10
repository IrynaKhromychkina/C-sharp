using System;

namespace BonusCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            string position = "Secretary";
            int hours = 140;
            Positions currentPosition;
            bool checkTheBonus = false;

            bool isParsed = Enum.TryParse<Positions>(position, out currentPosition);
            if (isParsed)
            {
                checkTheBonus = BonusCalculation.AskForBonus(currentPosition, hours);
                if (checkTheBonus)
                {
                    Console.WriteLine($"{position} will receive the bonus");
                }
                else
                {
                    Console.WriteLine($"{position} will not receive the bonus");
                }
            }
            else
            {
                Console.WriteLine("Wrong position entered");
            }

            Console.ReadKey();
        }
    }
}

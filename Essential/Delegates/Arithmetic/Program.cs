using System;

namespace Arithmetic
{
    class Program
    {
        public delegate double MyDelegate(int firstNumber, int secondNumber);
        public static (int, int) InputMethodNumbers()
        {
            (int, int) numbers = (0, 0);
            bool isRunning1 = true;

            while (isRunning1)
            {
                Console.WriteLine("Please enter the first number");
                string firstNumberStr = Console.ReadLine().Trim();
                bool firstNumberSuccess = Int32.TryParse(firstNumberStr, out numbers.Item1);

                if (firstNumberSuccess)
                {
                    isRunning1 = false;
                    bool isRunning2 = true;

                    while (isRunning2)
                    {
                        Console.WriteLine("Please enter the second number");
                        string secondNumberStr = Console.ReadLine().Trim();
                        bool secondNumberSuccess = Int32.TryParse(secondNumberStr, out numbers.Item2);

                        if (secondNumberSuccess)
                        {
                            isRunning2 = false;
                            Console.WriteLine("Thank you!");
                            return numbers;
                        }
                        else
                        {
                            Console.WriteLine("Wrong input. Please repeat\n");
                            continue;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input. Please repeat\n");
                    continue;
                }
            }
            return numbers;
        }
        public static int InputMethodOperations()
        {
            int operationInt = 0;
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Please enter the number of operation you want to execute: 1 - addition, 2 - subtraction, 3 - multiplication, 4 - division");
                string operationStr = Console.ReadLine().Trim();
                bool operationSuccess = Int32.TryParse(operationStr, out operationInt);

                if (operationSuccess && operationInt < 5 && operationInt > 0)
                {
                    Console.WriteLine("Thank you!");
                    return operationInt;
                }
                else
                {
                    Console.WriteLine("Wrong input. Please repeat\n");
                    continue;
                }
            }
            return operationInt;
        }
        public static void Main(string[] args)
        {
            MyDelegate myDelegateAdd = (int firstNumber, int secondNumber) => { return firstNumber + secondNumber; };
            MyDelegate myDelegateSub = (int firstNumber, int secondNumber) => { return firstNumber - secondNumber; };
            MyDelegate myDelegateMul = (int firstNumber, int secondNumber) => { return firstNumber * secondNumber; };
            MyDelegate myDelegateDiv = (int firstNumber, int secondNumber) =>
            {
                return
                    (secondNumber != 0)
                    ? (firstNumber / secondNumber)
                    : (firstNumber >= 0)
                      ? double.PositiveInfinity
                      : double.NegativeInfinity;
            };

            (int, int) numbers = InputMethodNumbers();

            int operationNumber = InputMethodOperations();
            double result = 0;

            switch (operationNumber)
            {
                case 1:
                    result = myDelegateAdd(numbers.Item1, numbers.Item2);
                    break;
                case 2:
                    result = myDelegateSub(numbers.Item1, numbers.Item2);
                    break;
                case 3:
                    result = myDelegateMul(numbers.Item1, numbers.Item2);
                    break;
                case 4:
                    result = myDelegateDiv(numbers.Item1, numbers.Item2);
                    break;
            }

            if (result == double.PositiveInfinity || result == double.NegativeInfinity)
            {
                Console.WriteLine("Division by zero is prohibited");
            }
            else
            {
                Console.WriteLine($"The result of operation chosen is: {result}");
            }
            
            Console.ReadKey();
        }
    }
}

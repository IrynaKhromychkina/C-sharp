using System;

namespace Calculator
{
    class Program
    {
        public static int InputNumber(string queryString)
        {
            int number;

            while (true)
            {
                Console.WriteLine(queryString);
                string numberStr = Console.ReadLine().Trim();
                try
                {
                    number = Int32.Parse(numberStr);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                return number;
            }
        }

        public static int InputMethodOperations()
        {
            int operationInt;

            while (true)
            {
                Console.WriteLine("Please enter the number of operation you want to execute: 1 - addition, 2 - subtraction, 3 - multiplication, 4 - division");
                string operationStr = Console.ReadLine().Trim();

                try
                {
                    operationInt = Int32.Parse(operationStr);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                if (operationInt <= 0 || operationInt > 4)
                {
                    Console.WriteLine("Wrong number. Try one more time");
                    continue;
                }
                return operationInt;
            }
        }

        static void Main(string[] args)
        {
            int firstNumber = InputNumber("Please enter the first number");
            int secondNumber = InputNumber("Please enter the second number");
            int operationNumber = InputMethodOperations();

            double result = 0;
            switch (operationNumber)
            {
                case 1:
                    result = Calculator.Addition(firstNumber, secondNumber);
                    Console.WriteLine($"Addition of {firstNumber} and {secondNumber} equals to {result}");
                    break;
                case 2:
                    result = Calculator.Subtraction(firstNumber, secondNumber);
                    Console.WriteLine($"Subtraction of {firstNumber} and {secondNumber} equals to {result}");
                    break;
                case 3:
                    result = Calculator.Multiplication(firstNumber, secondNumber);
                    Console.WriteLine($"Multiplication of {firstNumber} and {secondNumber} equals to {result}");
                    break;
                case 4:                    
                    try
                    {
                        result = Calculator.Division(firstNumber, secondNumber);
                        Console.WriteLine($"Division of {firstNumber} and {secondNumber} equals to {result}");
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}

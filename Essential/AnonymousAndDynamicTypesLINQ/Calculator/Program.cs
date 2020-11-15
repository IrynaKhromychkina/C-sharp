using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 4;
            int secondNumber = 3;

            dynamic result;

            result = Calculator.Addition(firstNumber, secondNumber);
            Console.WriteLine($"Addition of two numbers is: {result}");

            result = Calculator.Subtraction(firstNumber, secondNumber);
            Console.WriteLine($"Subtraction of two numbers is: {result}");

            result = Calculator.Multiplication(firstNumber, secondNumber);
            Console.WriteLine($"Multiplication of two numbers is: {result}");

            if (secondNumber == 0)
            {
                Console.WriteLine("Division by zero is prohibited");
            }
            else
            {
                result = Calculator.Division(firstNumber, secondNumber);
                Console.WriteLine($"Division of two numbers is: {result}");
            }
            
            Console.ReadKey();
        }
    }
}

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 3;
            int secondNumber = 5;

            int addResult = Calculator.Addition(firstNumber, secondNumber);
            Console.WriteLine($"Addition of {firstNumber} and {secondNumber} equals to {addResult}");

            int subResult = Calculator.Subtraction(firstNumber, secondNumber);
            Console.WriteLine($"Subtraction of {firstNumber} and {secondNumber} equals to {subResult}");

            int mulResult = Calculator.Multiplication(firstNumber, secondNumber);
            Console.WriteLine($"Multiplication of {firstNumber} and {secondNumber} equals to {mulResult}");

            double divResult = Calculator.Division(firstNumber, secondNumber);
            Console.WriteLine($"Division of {firstNumber} and {secondNumber} equals to {divResult}");

            Console.ReadKey();
        }
    }
}

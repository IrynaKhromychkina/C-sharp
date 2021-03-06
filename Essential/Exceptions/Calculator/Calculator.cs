﻿using System;

namespace Calculator
{
    static class Calculator
    {
        public static int Addition(int firstNumber, int secondNumber) => firstNumber + secondNumber;
        public static int Subtraction(int firstNumber, int secondNumber) => firstNumber - secondNumber;
        public static int Multiplication(int firstNumber, int secondNumber) => firstNumber * secondNumber;
        public static double Division(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new DivideByZeroException();
            }

            return firstNumber / (double)secondNumber;
        }
    }
}





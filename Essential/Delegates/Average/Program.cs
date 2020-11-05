using System;

namespace Average
{
    class Program
    {
        delegate double MyDelegate(int firstNumber, int secondNumber, int thirdNumber);
        static void Main(string[] args)
        {

            MyDelegate myDelegate = delegate (int firstNumber, int secondNumber, int thirdNumber) { return (firstNumber + secondNumber + thirdNumber) / 3d; };

            Console.WriteLine(myDelegate(12, 24, 2));
            Console.ReadKey();
        }
    }
}

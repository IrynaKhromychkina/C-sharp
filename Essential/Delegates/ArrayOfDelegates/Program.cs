using System;

namespace ArrayOfDelegates
{
    class Program
    {
        public delegate int MyDelegateNumbers();
        public delegate double MyDelegateAverage(MyDelegateNumbers[] numbers);
        public static int RandomNumber1()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int randomInt = random.Next(0,100);
            Console.WriteLine(randomInt);
            return randomInt;
        }
        public static int RandomNumber2()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int randomInt = random.Next(0,100);
            Console.WriteLine(randomInt);
            return randomInt;
        }
        public static int RandomNumber3()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int randomInt = random.Next(0,100);
            Console.WriteLine(randomInt);
            return randomInt;
        }

        public static double Average(MyDelegateNumbers[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i].Invoke();
            }

            double result = sum / (double)(numbers.Length);
            return result;
        }

        static void Main(string[] args)
        {
            MyDelegateNumbers myNumber1 = new MyDelegateNumbers(RandomNumber1);
            MyDelegateNumbers myNumber2 = new MyDelegateNumbers(RandomNumber2);
            MyDelegateNumbers myNumber3 = new MyDelegateNumbers(RandomNumber3);
           
            MyDelegateNumbers[] numbers = { myNumber1, myNumber2, myNumber3 };

            MyDelegateAverage myDelegateArray = new MyDelegateAverage(Average);
            double result = myDelegateArray.Invoke(numbers);

            Console.WriteLine($"The average is: {result}");

            Console.ReadKey();
        }
    }
}

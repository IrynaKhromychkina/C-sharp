using System;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = new Point(3, 5, 8);
            Point secondPoint = new Point(1, 1, 1);

            Point thirdPoint = firstPoint + secondPoint;

            Console.WriteLine(thirdPoint);

            Console.ReadKey();
        }
    }
}

using System;

namespace Tetragon
{
    class Program
    {
        static void Main(string[] args)
        {
            Tetragon firstTetragon = new Tetragon(4, 8, 9, 11);
            Tetragon secondTetragon = new Tetragon(4, 8, 9, 11);

            Tetragon thirdTetragon = new Tetragon(7, 2, 1, 1);

            Console.WriteLine(firstTetragon.GetHashCode());
            Console.WriteLine(secondTetragon.GetHashCode());
            Console.WriteLine(thirdTetragon.GetHashCode());
            
            Console.WriteLine($"fist = second? {firstTetragon.Equals(secondTetragon)}");
            Console.WriteLine($"first = third? {firstTetragon.Equals(thirdTetragon)}");

            Console.WriteLine(ReferenceEquals(firstTetragon, secondTetragon));

            Console.ReadKey();
        }
    }
}

using System;

namespace CarCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> myCarPark = new CarCollection<Car>(10);
            myCarPark.Add("Tesla", 2019);
            myCarPark.Add("Ford", 2020);
            myCarPark.Add("Audi", 2018);
            myCarPark.Add("Alfa Romeo", 2015);

            Console.WriteLine($"My car park contains {myCarPark.Count} cars");
            Console.WriteLine($"The second car in my park is - '{myCarPark[1]}'");
            Console.WriteLine($"The fifth car in my car park is - '{myCarPark[5]}'");

            Console.ReadKey();
        }
    }
}

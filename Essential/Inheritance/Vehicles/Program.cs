using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(47.636997, 121.823473, 925, 425000000, 2019, 707100, 700);
            plane.ShowInfo();

            Ship ship = new Ship(48.221127, 123.042059, 140, 8000000, 2017, "Ludlow Marina", 6400);
            ship.ShowInfo();

            Car car = new Car(47.615952, 122.310315, 240, 70000, 2020);
            car.ShowInfo();

            Console.ReadKey();
        }
    }
}

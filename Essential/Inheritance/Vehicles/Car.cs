using System;

namespace Vehicles
{
    class Car : Vehicle
    {
        public Car(double latitude, double longitude, int speed, int price, int year)
                              : base(latitude, longitude, speed, price, year)
        { }

        public override void ShowInfo()
        {
            Console.WriteLine("\tCar details:");
            base.ShowInfo();
            Console.WriteLine("\n\tNo additional info about car");
        }
    }
}

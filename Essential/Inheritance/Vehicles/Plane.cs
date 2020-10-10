using System;

namespace Vehicles
{
    class Plane : Vehicle
    {
        private int planeAltitude;
        private int planeCapacity;

        public Plane(double latitude, double longitude, int speed, int price, int year, int altitude, int capacity)
                              : base(latitude, longitude, speed, price, year)
        {
            planeAltitude = altitude;
            planeCapacity = capacity;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("\tPlane details:");
            base.ShowInfo();
            Console.WriteLine($"\n\tAdditionally about plane:\nAltitude: {planeAltitude} meters\nCapacity: {planeCapacity} people on board\n");
        }
    }
}



using System;

namespace Vehicles
{
    class Ship : Vehicle
    {
        private string port;
        private int shipCapacity;

        public Ship(double latitude, double longitude, int speed, int price, int year, string port, int capacity)
                              : base(latitude, longitude, speed, price, year)
        {
            this.port = port;
            shipCapacity = capacity;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("\tShip details:");
            base.ShowInfo();
            Console.WriteLine($"\n\tAdditionally about ship:\nPort: {port} port\nCapacity: {shipCapacity} people on board\n");
        }
    }
}


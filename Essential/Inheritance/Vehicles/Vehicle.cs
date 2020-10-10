using System;

namespace Vehicles
{
    class Vehicle
    {
        public double latitude;
        public double longitude;
        public int speed;
        public int price;
        public int year;

        public Vehicle(double latitude, double longitude, int speed, int price, int year)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.speed = speed;
            this.price = price;
            this.year = year;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Latitude: {latitude}\nLongitude: {longitude}");
            Console.WriteLine($"Speed: {speed} km per hour\nYear: {year} year\nPrice: {price} USD");
        }
    }
}

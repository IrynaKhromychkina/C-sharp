using System;

namespace CarCollection
{
    public class Car
    {
        public string CarModel { get; set; }
        public int CarYear { get; set; }

        public Car(string model, int year)
        {
            CarModel = model;
            CarYear = year;
        }
        public override string ToString()
        {
            return $"Car model is: {CarModel}. Car year is : {CarYear}";
        }
        public Car() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace DealershipBase
{
    class Program
    {
        static void Main(string[] args)
        {
            string buyerName = "Irina Ledon";

            var cars = new List<Cars>
            {
                new Cars ("Tesla", "ModelS", "Red", 2019),
                new Cars ("Volvo", "Concept Coupe", "Granite", 2020),
                new Cars ("Mazda", "CX", "Blue", 2019),
            };

            var buyers = new List<Buyers>
            {
                new Buyers ("ModelS", "Irina Ledon", 12345678),
                new Buyers ("Concept Coupe", "Irina Ledon", 12345678),
                new Buyers ("Concept Coupe", "Daniil Rakitzkii", 24567847),
                new Buyers ("CX", "Pavel Dobrinin", 58378903),
            };

            var queryResult =
                from buyer in buyers
                    where buyer.Name == buyerName
                    from car in cars
                        where car.Model == buyer.Model
                        select new
                        {
                            BuyerName = buyer.Name,
                            BuyerNumber = buyer.PhoneNumber,
                            CarBrand = car.Brand,
                            CarModel = car.Model,
                            CarColor = car.Color,
                            CarYear = car.Year
                        };
      
            foreach (var item in queryResult)
            {
                Console.WriteLine($"Buyer's name: {item.BuyerName}");
                Console.WriteLine($"Buyer's phone number: {item.BuyerNumber}");
                Console.WriteLine($"Car brand: {item.CarBrand}");
                Console.WriteLine($"Car model: {item.CarModel}");
                Console.WriteLine($"Car color {item.CarColor}");
                Console.WriteLine($"Car year: {item.CarYear}");

                Console.WriteLine(new string ('_', 50));
            }

            Console.ReadKey();
        }
    }
}

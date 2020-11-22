using System;
using System.Linq;

namespace ProductsDataBase
{
    public struct Price
    {
        string product;
        string shop;
        double price;

        public static Price[] InputMethod(int productsQuantity)
        {
            Price[] products = new Price[productsQuantity];

            Console.WriteLine($"\t\tAttention:\n You will have to enter the information about {productsQuantity} products to the products base.\n");

            for (int i = 0; i < products.Length; i++)
            {
                string product = InputString("Please enter the product");
                products[i].product = product;

                string shop = InputString("Please enter the shop");
                products[i].shop = shop;

                double price = InputDouble("Please enter the price in UAH (use point to separate the decimal)");
                products[i].price = price;
            }
            return products;
        }

        public static string InputString(string startString)
        {
            while (true)
            {
                Console.WriteLine(startString);
                string inputString = Console.ReadLine().Trim().ToLower();

                if (String.IsNullOrEmpty(inputString) == false)
                {
                    return inputString;
                }
                else
                {
                    Console.WriteLine("Wrong input. Please repeat");
                    continue;
                }
            }
        }

        public static double InputDouble(string startString)
        {
            while (true)
            {
                Console.WriteLine(startString);
                string yearOfEmployementStr = Console.ReadLine().Trim();
                double price;

                if (Double.TryParse(yearOfEmployementStr, out price))
                {
                    return price;
                }
                else
                {
                    Console.WriteLine("You have entered the price in a wrong format. Please repeat");
                    continue;
                }
            }
        }

        public static Price[] Sort(Price[] products)
        {
            return products.OrderBy(i => i.shop).ToArray();
        }

        public static string EnterShop(Price[] productsSorted)
        {
            while (true)
            {
                Console.WriteLine("\n\t\tPlease enter the shop, which products have to be shown.\n");
                string shop = Console.ReadLine().Trim().ToLower();
                try
                {
                    for (int i = 0; i < productsSorted.Length; i++)
                    {
                        if (productsSorted[i].shop == shop)
                        {
                            return shop;
                        }
                    }
                    throw new WrongShopException("You have entered wrong shop info.");
                }
                catch (WrongShopException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }

        }

        public static void ShowProductBase(Price[] productsSorted, string shop)
        {
            for (int i = 0; i < productsSorted.Length; i++)
            {
                if (productsSorted[i].shop == shop)
                {
                    Console.WriteLine($"Shop : {productsSorted[i].shop}");
                    Console.WriteLine($"Product : {productsSorted[i].product}");
                    Console.WriteLine($"Price in UAH : {productsSorted[i].price}");
                }
            }
        }

        public static void ShowAllProducts(Price[] productsSorted)
        {
            Console.WriteLine("\n\t\tHere is the information about products you have entered (alphabetically sorted).\n");
            for (int i = 0; i < productsSorted.Length; i++)
            {
                Console.WriteLine($"Shop : {productsSorted[i].shop}");
                Console.WriteLine($"Product : {productsSorted[i].product}");
                Console.WriteLine($"Price in UAH : {productsSorted[i].price}");
            }
        }
    }
}

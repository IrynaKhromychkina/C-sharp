using System;

namespace ProductsDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int productsQuantity = 2;

            Price[] products = Price.InputMethod(productsQuantity);

            Price[] productsSorted = Price.Sort(products);

            Price.ShowAllProducts(productsSorted);

            string shop = Price.EnterShop(productsSorted);

            Price.ShowProductBase(productsSorted, shop);

            Console.ReadKey();
        }
    }
}

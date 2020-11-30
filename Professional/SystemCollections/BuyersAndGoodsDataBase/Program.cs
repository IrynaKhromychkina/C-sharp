using System;
using System.Collections.Specialized;
using System.Linq;

namespace BuyersAndGoodsDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var buyersAndGoodsData = new NameValueCollection();
            buyersAndGoodsData.Add("Maria", "Fresh fruits");
            buyersAndGoodsData.Add("Maria", "Bakery");
            buyersAndGoodsData.Add("Maria", "Home goods");
            buyersAndGoodsData.Add("Antonio", "Alcohol");
            buyersAndGoodsData.Add("Antonio", "Bakery");
            buyersAndGoodsData.Add("Antonio", "Fresh fruits");

            Console.WriteLine("Antonio bought:");

            foreach (string value in buyersAndGoodsData.GetValues("Antonio"))
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("");

            string goodsToFind = "Bakery";
            Console.WriteLine($"The following buyers bought {goodsToFind}:");

            var buyersSelected =
                from buyer in buyersAndGoodsData.AllKeys
                where buyersAndGoodsData.GetValues(buyer).Contains(goodsToFind)
                select buyer;

            foreach (var buyer in buyersSelected)
            {
                Console.WriteLine(buyer);
            }

            Console.ReadKey();
        }
    }
}

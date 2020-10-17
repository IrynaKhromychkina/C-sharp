using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Store myStore = new Store(10);
            myStore[0] = new Article("milk", "Target", 3.5);
            myStore[1] = new Article("cheese", "Wholefoods", 12);
            myStore[2] = new Article("cookies", "Wholefoods", 4);
            myStore[3] = new Article("lamb", "Target", 19);
            myStore[4] = new Article("pork", "Safeway", 12);
            myStore[5] = new Article("butter", "QFC", 9.6);
            myStore[6] = new Article("bread", "Target", 3);
            myStore[7] = new Article("ice-cream", "Wholefoods", 8);
            myStore[8] = new Article("cabbage", "Fred Meyer", 2);
            myStore[9] = new Article("eggplant", "Target", 0.99);
            
            myStore[7]?.ShowGoodsInfo();

            Console.WriteLine("Please enter the product type");
            string goodsInput = Console.ReadLine().ToLower().Trim();

            myStore[goodsInput]?.ShowGoodsInfo();

            Console.ReadKey();
        }
    }
}

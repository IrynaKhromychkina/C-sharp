using System;

namespace Store
{
    class Article
    {
        private string goodType;
        private string distributor;
        private double price;

        public Article(string goodType, string distributor, double price)
        {
            this.goodType = goodType;
            this.distributor = distributor;
            this.price = price;
        }

        public void ShowGoodsInfo()
        {
            Console.WriteLine($"Good type is {goodType}.\nDistribitor is {distributor}.\nPrice is {price}\n");
        }

        public string GoodsType => goodType;
    } 
}



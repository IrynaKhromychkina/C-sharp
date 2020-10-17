using System;

namespace Store
{
    class Store
    {
        private uint quantity;
        private Article[] goodsInfo;

        public Store(uint quantity)
        {
            this.quantity = quantity;
            goodsInfo = new Article[quantity];
        }

        public Article this[uint index]
        {
            get
            {
                if (index >= quantity)
                {
                    return null;
                }
                else
                {
                    return goodsInfo[index];
                }
            }
            set
            {
                if (index >= quantity)
                {
                    Console.WriteLine("This product index is not in the store scope");
                }
                else
                {
                    goodsInfo[index] = value;
                }
            }
        }

        public Article this[string goodsType]
        {
            get
            {
                for (int i = 0; i < goodsInfo.Length; i++)
                {
                    if (goodsInfo[i].GoodsType == goodsType)
                    {
                        return goodsInfo[i];
                    }
                }

                Console.WriteLine("There is no such product in the store");
                return null;
            }
        }
    }
}


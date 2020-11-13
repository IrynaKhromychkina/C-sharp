using System;

namespace ProductsDataBase
{
    class WrongShopException : Exception
    {
        public WrongShopException(string message) : base(message) { }
    }
}


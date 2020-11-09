using System;

namespace Notebook
{
    struct Notebook
    {
        string model;
        string manufacturer;
        int price;
        public Notebook(string model, string manufacturer, int price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Model: {model}\nManufacturer: {manufacturer}\nPrice : {price} USD");
        }
    }
}

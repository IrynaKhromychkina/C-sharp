using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricClass
{
    class Product
    {
        private static int instanceCounter = 0;

        public int CurrentInstanceNumber { get; private set; }
        public Product()
        {
            instanceCounter++;
            CurrentInstanceNumber = instanceCounter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product myProduct = MyClass<Product>.FactoryMethod();
            Console.WriteLine($"Product number {myProduct.CurrentInstanceNumber} was created");

            Product myProduct2 = MyClass<Product>.FactoryMethod();
            Console.WriteLine($"Product number {myProduct2.CurrentInstanceNumber} was created");

            Console.ReadKey();
        }
    }
}

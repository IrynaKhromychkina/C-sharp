using System;
using FirstNamespaceAndAssembly;

namespace SecondNamespaceAndAssembly
{
    class Program : MyProgram
    {
        static void Main(string[] args)
        {
            MyProgram exampleProgram = new MyProgram();
            exampleProgram.ExampleMethod();

            Console.ReadKey();
        }
    }
}

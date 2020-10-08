using System;

namespace InvoiceVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(5454, "Suntrade", "Techagro") { Article = "harvester", Quantity = 20 };
            invoice.ShowOptionsToPay();

            Console.ReadKey();
        }
    }
}

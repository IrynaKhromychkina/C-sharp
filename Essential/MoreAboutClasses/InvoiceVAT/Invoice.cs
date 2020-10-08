using System;

namespace InvoiceVAT
{
    public class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;

        //private string article; //These two fields will not be used in the program because when we use auto-implemented properties
        //private int quantity;  //the compiler creates private anonymous fields automatically. So, we can delete these two lines of code.
        public Invoice(int account, string customer, string provider)

        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public string Article { get; set; }
        public int Quantity { get; set; }

        public void ShowOptionsToPay()
        {
            int priceWithoutVAT = 0;
            switch (Article)
            {
                case "harvester":
                    {
                        priceWithoutVAT = 1000;
                        break;
                    }
                case "tractor":
                    {
                        priceWithoutVAT = 800;
                        break;
                    }
                case "snowplow":
                    {
                        priceWithoutVAT = 500;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong article/Product ID.");
                        break;
                    }
            }

            if (priceWithoutVAT > 0)
            {
                Console.WriteLine($"\t\tInvoice No: {account} - {DateTime.Now.ToString("dd/MM/yyy")}\n");
                Console.WriteLine($"Customer: {customer}" + new string(' ', 15) + $"Provider: {provider}");
                Console.WriteLine($"Product ID: {Article}" + new string(' ', 12) + $"Quantity: {Quantity}\n");
                Console.WriteLine(new string('_', 50));
                Console.WriteLine($"Total cost without VAT: {(priceWithoutVAT * Quantity)}\n");
                Console.WriteLine($"Total cost with VAT: {(priceWithoutVAT * Quantity * 1.2)}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassProgram
{
    
    class Program
    {

        static void Main(string[] args)
        {
            Address myAddress = new Address();
            myAddress.Index = 98109;
            myAddress.Country = "USA";
            myAddress.City = "Seattle";
            myAddress.Street = "Terry avenue";
            myAddress.House = 410;
            myAddress.Apartment = 307;

            Console.WriteLine($"{myAddress.Index}, {myAddress.Country}, {myAddress.City}, {myAddress.House} {myAddress.Street}, {myAddress.Apartment}");
            Console.ReadKey();

        }
    }
}
    

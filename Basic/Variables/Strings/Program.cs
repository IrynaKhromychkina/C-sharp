using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myFirstString = "\nmy string 1"; //new line
            string mySecondString = "\tmy string 2"; //tab
            string myThirdString = "\amy string 3";   //beep (but different from Console.beep();

            Console.WriteLine(myFirstString);
            Console.WriteLine(mySecondString);
            Console.WriteLine(myThirdString);
            
            Console.ReadKey();
        }
    }
}

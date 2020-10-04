using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncapsulationExample
{
    class Title
    {
        private string bookTitle;

        public Title(string title)
        {
            bookTitle = title;
        }

        public string BookTitle
        {
            get
            {
                if (bookTitle != null)
                    return bookTitle;
                else
                    return "No title";
            }
            set
            {
                bookTitle = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(BookTitle);
            Console.ResetColor();
        }
    }
}

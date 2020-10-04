using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncapsulationExample
{
    class Author
    {
        string bookAuthor;

        public Author(string author)
        {
            bookAuthor = author;
        }

        public string BookAuthor
        {
            get
            {
                if (bookAuthor != null)
                    return bookAuthor;
                else
                    return "No info about the author";
            }
            set
            {
                bookAuthor = value;
            }
        }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(BookAuthor);
            Console.ResetColor();
        }

    }
}

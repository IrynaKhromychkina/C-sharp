using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncapsulationExample
{
    class Content
    {
        string bookContent;

        public Content(string content)
        {
            bookContent = content;
        }

        public string BookContent
        {
            get
            {
                if (bookContent != null)
                    return bookContent;
                else
                    return "No info about the content";
            }

            set
            {
                bookContent = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(BookContent);
            Console.ResetColor();
        }
    }
}

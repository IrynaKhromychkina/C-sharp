using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncapsulationExample
{
    class Book
    {
        Title book1Title;
        Author book1Author;
        Content book1Content;


        public void Show()
        {
            book1Title?.Show();
            book1Author?.Show();
            book1Content?.Show();
        }

        public string MyTitle
        {
            set
            {
                book1Title = new Title(value);
            }
        }

        public string MyAuthor
        {
            set
            {
                book1Author = new Author(value);
            }
        }

        public string MyContent
        {
            set
            {
                book1Content = new Content(value);
            }
        }
    }
}

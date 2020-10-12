using System;

namespace WorkWithDocument
{
    class Program
    {
        static void Main()
        {
            Title title = new Title();
            title.Content = "\tContract";

            Body body = new Body();
            body.Content = "I HATE green color...";

            Footer footer = new Footer();
            footer.Content = "CEO Mr.A.Greenhater.\nP.S.And red color I like.";

            Document document = new Document(title, body, footer);
            document.Show();

            Console.ReadKey();
        }
    }
}

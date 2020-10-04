using System;

namespace SimpleEncapsulationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();


            book1.MyTitle = "Anna Karenina";
            book1.MyAuthor = "Lev Tolstoi";
            book1.MyContent = "Woman.Train.Drama";
            book1.Show();

            Console.ReadKey();
        }
    }


}

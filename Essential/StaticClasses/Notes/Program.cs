using System;

namespace Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            string myNote1 = "This is fascinating book";
            string myNote2 = "Drinking cacao while reading is cozy";
            string myNote3 = "Last chapter is surprising";

            Book.Notes firstBookNotes = new Book.Notes();

            firstBookNotes.SaveMyNotes(myNote1);
            firstBookNotes.SaveMyNotes(myNote2);
            firstBookNotes.SaveMyNotes(myNote3);

            firstBookNotes.Show(); //uncomment this if you wanna see your notes

            Console.ReadKey();
        }
    }
}

using System;

namespace Notes
{
    public class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Searching for the string: " + str);
        }

        public class Notes
        {
            string[] myNotes = new string[0];

            public void SaveMyNotes(string myNote)
            {
                Array.Resize(ref myNotes, myNotes.Length + 1);
                myNotes[myNotes.Length - 1] = myNote;
            }

            public void Show()
            {
                for (int i = 0; i < myNotes.Length; i++)
                {
                    Console.WriteLine($"My note {i+1} - " +myNotes[i]);
                }
            }
        }
    }

}

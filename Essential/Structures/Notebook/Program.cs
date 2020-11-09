using System;

namespace Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook myNote = new Notebook("Tesla model S", "Tesla Inc.", 140000);
            
            myNote.ShowInfo();

            Console.ReadKey();
        }
    }
}

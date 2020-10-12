using System;
using System.IO;

namespace DocumentsHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the path to the document you want to open");
            string path = Console.ReadLine().Trim();
            string extension = Path.GetExtension(path);
            AbstractHandler handler = CreateFileHandler(extension);

            if (handler == null)
            {
                Console.WriteLine("Application works with .doc, .txt and .xml files only");
            }
            else 
            {
                handler.Open();
                handler.Create();
                handler.Change();
                handler.Save();
            }
            
            Console.ReadKey();
        }

        public static AbstractHandler CreateFileHandler(string extension)
        {
            switch (extension)
            {
                case ".doc":
                    {
                        return new DOCHandler();
                    }
                case ".txt":
                    {
                        return new TXTHandler();
                    }
                case ".xml":
                    {
                        return new XMLHandler();
                    }
            }

            return null;
        }
    }
}
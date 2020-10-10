using System;

namespace DocumentAccessLevels
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker document;
            Console.WriteLine("Please enter the Pro or Expert code");
            string code = Console.ReadLine().ToLower().Trim();

            switch (code)
            {
                case "pro":
                    {
                        document = new ProDocumentWorker();
                        break;
                    }
                case "expert":
                    {
                        document = new ExpertDocumentWorker();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("The code is empty or incorrect. You will have acces to the free version only");
                        document = new DocumentWorker();
                        break;
                    }
            }

            document.OpenDocument();
            document.EditDocument();
            document.SaveDocument();

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsWorkingWithFiles
{
    class Program
    {

        static object block = new object();
        static string resultFileName = "Joke.txt";

        static void Read(string path)
        {
            if (File.Exists(path))
            {
                string[] content = File.ReadAllLines(path, Encoding.UTF8);
                Write(content);
            }
        }

        static void Write(string[] content)
        {

            lock (block)
            {
                using (FileStream fileStream = new FileStream(resultFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    fileStream.Seek(0, SeekOrigin.End);
                    using (var writer = new StreamWriter(fileStream, Encoding.UTF8))
                    {
                        for (int i = 0; i < content.Length; i++)
                        {
                            writer.WriteLine(content[i]);
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            string[] filePaths = new string[] {
                @"C:\Sources\csharp\Professional\Threads\ThreadsWorkingWithFiles\bin\Debug\FirstDoc.txt",
                @"C:\Sources\csharp\Professional\Threads\ThreadsWorkingWithFiles\bin\Debug\SecondDoc.txt"};

            var threads = filePaths.Select(fn => new Thread(() => { Read(fn); })).ToArray();

            foreach (Thread thread in threads)
            {
                thread.Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}

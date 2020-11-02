using System;
using System.Threading;

namespace MatrixScreen
{
    class Program
    {
        Random random = new Random(DateTime.Now.Millisecond);
        public void ChainManager(int colomn)
        {
            Chain myChain = new Chain(40);
            while (true)
            {
                myChain.WordFall(colomn, random.Next(2, 10));
            }
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(85, 45);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Program program = new Program();
            program.Run();
        }

        public void Run()
        {
            for (int i = 0; i < 80; i += 4)
            {
                Thread myThread = new Thread(() => ChainManager(i));
                myThread.Start();
                Thread myThread1 = new Thread(() => ChainManager(i));
                myThread1.Start();
            }
        }
    }
}

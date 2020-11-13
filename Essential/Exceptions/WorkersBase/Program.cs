using System;

namespace WorkersBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int workersQuantity = 5;

            Worker[] workers = Worker.InputMethod(workersQuantity);

            Worker[] workersSorted = Worker.Sort(workers);

            Worker.ShowAllWorkers(workersSorted);

            int experience = Worker.EnterExperience();

            Worker.ShowWorkerInfo(workersSorted, experience);

            Console.ReadKey();
        }
    }
}

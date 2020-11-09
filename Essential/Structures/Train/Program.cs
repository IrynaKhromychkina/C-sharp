using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainsQuantity = 3;

            Train[] myTrains = Train.InputMethod(trainsQuantity);

            Train[] myTrainsSorted = Train.Sort(myTrains);

            Train.ShowMyTrains(myTrainsSorted);

            Train.ShowTrainInfo(myTrainsSorted);

            Console.ReadKey();
        }
    }
}




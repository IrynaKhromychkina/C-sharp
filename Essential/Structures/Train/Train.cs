using System;

namespace Train
{
    struct Train
    {
        string destination;
        int trainNumber;
        string timeDeparture;

        public static Train[] InputMethod(int trainsQuantity)
        {
            Train[] trains = new Train[trainsQuantity];

            Console.WriteLine($"\t\tAttention:\n You will have to enter the information about {trainsQuantity} train routes.\n");

            for (int i = 0; i < trains.Length; i++)
            {
                bool isRunning1 = true;

                while (isRunning1)
                {
                    Console.WriteLine("Please enter the destination");
                    string destination = Console.ReadLine().Trim();

                    if (String.IsNullOrEmpty(destination) == false)
                    {
                        isRunning1 = false;
                        bool isRunning2 = true;
                        trains[i].destination = destination;

                        while (isRunning2)
                        {
                            Console.WriteLine("Please enter the number of train");
                            string trainNumberStr = Console.ReadLine().Trim();
                            bool successTrainNumber = Int32.TryParse(trainNumberStr, out int trainNumberInt);

                            if (successTrainNumber && trainNumberInt != 0)
                            {
                                isRunning2 = false;
                                bool isRunning3 = true;
                                trains[i].trainNumber = trainNumberInt;

                                while (isRunning3)
                                {
                                    Console.WriteLine("Please enter the time of departue");
                                    string timeDeparture = Console.ReadLine().Trim();

                                    if (String.IsNullOrEmpty(timeDeparture) == false)
                                    {
                                        isRunning3 = false;
                                        Console.WriteLine("Thank you!\n");

                                        trains[i].timeDeparture = timeDeparture;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Wrong time departure input.\n");
                                        continue;
                                    }
                                }
                            }

                            else
                            {
                                Console.WriteLine("Wrong train number input.\n");
                                continue;
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("Wrong destination input.\n");
                        continue;
                    }
                }
            }

            return trains;
        }
        public static Train[] Sort(Train[] myTrains)
        {
            Train tempTrain;
            for (int i = 0; i < myTrains.Length - 1; i++)
            {
                for (int j = i + 1; j < myTrains.Length; j++)
                {
                    if (myTrains[i].trainNumber > myTrains[j].trainNumber)
                    {
                        tempTrain = myTrains[i];
                        myTrains[i] = myTrains[j];
                        myTrains[j] = tempTrain;
                    }
                }
            }
            return myTrains;
        }
        public static void ShowTrainInfo(Train[] myTrainsSorted)
        {
            Console.WriteLine("\n\t\tNow you can request the information about every train.\n");
            Console.WriteLine("Enter the number of train.");

            string trainNumberStr = Console.ReadLine().Trim();
            bool successTrainNumber = Int32.TryParse(trainNumberStr, out int trainNumberInt);

            if (successTrainNumber)
            {
                for (int i = 0; i < myTrainsSorted.Length; i++)
                {
                    if (trainNumberInt == myTrainsSorted[i].trainNumber)
                    {
                        Console.WriteLine($"Train number : {myTrainsSorted[i].trainNumber}");
                        Console.WriteLine($"Train destination : {myTrainsSorted[i].destination}");
                        Console.WriteLine($"Departure time : {myTrainsSorted[i].timeDeparture}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("There is no information about this route.");
                        continue;
                    }
                }
            }
        }
        public static void ShowMyTrains(Train[] myTrainsSorted)
        {
            Console.WriteLine("\n\t\tHere is the information about trains you have entered categorized by numbers.\n");
            for (int i = 0; i < myTrainsSorted.Length; i++)
            {
                Console.WriteLine($"Train number : {myTrainsSorted[i].trainNumber}");
                Console.WriteLine($"Train destination : {myTrainsSorted[i].destination}");
                Console.WriteLine($"Departure time : {myTrainsSorted[i].timeDeparture}");
            }
        }
    }
}

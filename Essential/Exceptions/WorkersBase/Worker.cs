using System;
using System.Globalization;
using System.Linq;

namespace WorkersBase
{
    struct Worker
    {
        string fullName;
        string position;
        DateTime dateOfEmployement;

        public static Worker[] InputMethod(int workersQuantity)
        {
            Worker[] workers = new Worker[workersQuantity];

            Console.WriteLine($"\t\tAttention:\n You will have to enter the information about {workersQuantity} workers to the workers base.\n");

            for (int i = 0; i < workers.Length; i++)
            {
                string fullNameStr = InputString("Please enter the workers full name");
                workers[i].fullName = fullNameStr;

                string position = InputString("Please enter the workers position");
                workers[i].position = position;

                DateTime yearOfEmployement = InputDateTime("Please enter the year of employement in the following format DD/MM/YYYY");
                workers[i].dateOfEmployement = yearOfEmployement;
            }
            return workers;
        }

        public static string InputString(string startString)
        {
            while (true)
            {
                Console.WriteLine(startString);
                string inputString = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(inputString) == false)
                {
                    return inputString;
                }
                else
                {
                    Console.WriteLine("Wrong input. Please repeat");
                    continue;
                }
            }
        }

        public static DateTime InputDateTime(string startString)
        {
            while (true)
            {
                Console.WriteLine(startString);
                string yearOfEmployementStr = Console.ReadLine().Trim();
                DateTime dateOfEmployement;

                try
                {
                    if (DateTime.TryParseExact(yearOfEmployementStr, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out dateOfEmployement))
                    {
                        return dateOfEmployement;
                    }
                    else
                    {
                        throw new WrongYearException("You have entered wrong start date of employement. Please repeat");
                    }
                }
                catch (WrongYearException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }
        }

        public static Worker[] Sort(Worker[] workers)
        {
            return workers.OrderBy(i => i.fullName).ToArray();
        }

        public static int EnterExperience()
        {
            while (true)
            {
                Console.WriteLine("\n\t\tPlease enter years of experience of the worker, which has to be shown.\n");

                string experienceStr = Console.ReadLine().Trim();
                try
                {
                    int experienceInt = Int32.Parse(experienceStr);
                    return experienceInt;
                }
                catch (Exception ex) when (ex is ArgumentNullException || ex is FormatException)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void ShowWorkerInfo(Worker[] workersSorted, int experience)
        {
            TimeSpan tempExperience;
            DateTime tempWorkerYear;
            for (int i = 0; i < workersSorted.Length; i++)
            {
                tempWorkerYear = workersSorted[i].dateOfEmployement;
                tempExperience = DateTime.Now - tempWorkerYear;

                if (tempExperience.TotalDays > (experience * 365))
                {
                    Console.WriteLine($"Full Name : {workersSorted[i].fullName}");
                    Console.WriteLine($"Position : {workersSorted[i].position}");
                    string date = workersSorted[i].dateOfEmployement.ToString("MMMM dd, yyyy");
                    Console.WriteLine($"Date of employement : {date}");
                }
            }
        }

        public static void ShowAllWorkers(Worker[] workersSorted)
        {
            Console.WriteLine("\n\t\tHere is the information about workers you have entered (alphabetically sorted).\n");
            for (int i = 0; i < workersSorted.Length; i++)
            {
                Console.WriteLine($"Full Name : {workersSorted[i].fullName}");
                Console.WriteLine($"Position : {workersSorted[i].position}");
                string date = workersSorted[i].dateOfEmployement.ToString("MMMM dd, yyyy");
                Console.WriteLine($"Date of employement : {date}");
            }
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitizenList
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { Name = "Ivan Ivanov", Passport = "EK75960" };
            Employed employed = new Employed() { Name = "Ivan Ivanov", Passport = "EK75960" };
            Retired retired = new Retired() { Name = "Petr Petrov", Passport = "TY878203" };

            CitizensCollection citizens = new CitizensCollection();
            citizens.Add(student);
            citizens.Add(retired);

            try
            {
                Console.WriteLine("Attempt to add a person with the same passport number");
                citizens.Add(employed);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(new string('_', 50));

            foreach (Citizen citizen in citizens)
            {
                Console.WriteLine($"{citizen.GetType().Name}. Name: {citizen.Name}. Passport: {citizen.Passport}.");
            }

            Console.WriteLine(new string('_', 50));

            Console.WriteLine("Check if the collection contains requested citizen");
            Retired retired1 = new Retired() { Name = "Stanislav Petrov", Passport = "HJ869595" };

            (bool, int) result = citizens.Contains(retired1);
            Console.WriteLine($"Collection contains the requested citizen: {result.Item1}");
            result = citizens.Contains(retired);
            Console.WriteLine($"Collection contains the requested citizen: {result.Item1}. Number in the collection: {result.Item2}");
            Console.WriteLine(new string('_', 50));

            Console.WriteLine($"Last citizen is {citizens.ReturnLast().Item1.Name} with the passport number {citizens.ReturnLast().Item1.Passport} and its number in collection is {citizens.ReturnLast().Item2}");
            Console.WriteLine(new string('_', 50));

            Console.WriteLine("Remove the data about citizen");
            citizens.Remove(student);
            citizens.Remove(retired1);
            foreach (Citizen citizen in citizens)
            {
                Console.WriteLine($"{citizen.GetType().Name}. Name: {citizen.Name}. Passport: {citizen.Passport}.");
            }

            Console.ReadKey();
        }
    }
}

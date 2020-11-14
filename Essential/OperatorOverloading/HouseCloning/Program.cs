using System;

namespace HouseCloning
{
    class Program
    {
        //When a House object is cloned by calling the MemberwiseClone method, the cloned House object is an independent copy of the original object,
        //except that they share the same House.HouseOwner object reference. As a result, modifying the clone's House.HouseOwner Name and Surname properties changes the original
        //object's House.HouseOwner properties. On the other hand, when a deep copy operation is performed, the cloned House object, including its House.HouseOwner properties,
        //can be modified without affecting the original object.
        static void Main(string[] args)
        {
            House original = new House(3000, new Owner("Irina", "Ledon"));

            Console.WriteLine($"Original house is {original.FloorSpace} square feet and it belongs to {original.HouseOwner.Name} {original.HouseOwner.Surname}");

            House shallowClone = original.Clone();
            Console.WriteLine($"Shallow clone house is {shallowClone.FloorSpace} square feet and it belongs to {shallowClone.HouseOwner.Name} {shallowClone.HouseOwner.Surname}");

            Console.WriteLine(new string('_', 80));

            original.FloorSpace = 4000;
            original.HouseOwner.Name = "Ivan";
            original.HouseOwner.Surname = "Abramov";

            Console.WriteLine("After original house was changed:");
            Console.WriteLine($"Original house is {original.FloorSpace} square feet and it belongs to {original.HouseOwner.Name} {original.HouseOwner.Surname}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Shallow clone house is {shallowClone.FloorSpace} square feet and it belongs to {shallowClone.HouseOwner.Name} {shallowClone.HouseOwner.Surname}");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine(new string('_', 80));

            House deepClone = original.DeepClone();
            Console.WriteLine($"Original house is {original.FloorSpace} square feet and it belongs to {original.HouseOwner.Name} {original.HouseOwner.Surname}");
            Console.WriteLine($"Deep clone house is {deepClone.FloorSpace} square feet and it belongs to {deepClone.HouseOwner.Name} {deepClone.HouseOwner.Surname}");

            Console.WriteLine(new string('_', 80));

            deepClone.FloorSpace = 5000;
            deepClone.HouseOwner.Name = "Pavel";
            deepClone.HouseOwner.Surname = "Skorobogatov";

            Console.WriteLine("After original house was changed:");
            Console.WriteLine($"Original house is {original.FloorSpace} square feet and it belongs to {original.HouseOwner.Name} {original.HouseOwner.Surname}");
            Console.WriteLine($"Deep clone house is {deepClone.FloorSpace} square feet and it belongs to {deepClone.HouseOwner.Name} {deepClone.HouseOwner.Surname}");

            Console.ReadKey();
        }
    }
}

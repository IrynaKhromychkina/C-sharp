using System;

namespace ClassWithReadOnlyField
{
    class Program
    {
        static void Main(string[] args)
        {
            User newUser = new User("newUser", "Irene", "Ledon", 14, "Oct 3rd, 2020");
            newUser.ShowUser();

            Console.ReadKey();

            
        }
    }
}

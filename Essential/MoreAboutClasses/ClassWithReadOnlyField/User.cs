using System;

namespace ClassWithReadOnlyField
{
    public class User
    {   
        private readonly string date; //date = "Hello";  Will be an error here because date is a readonly field.

        private string login;
        private string name;
        private string surname;
        private int age;

        public User(string login, string name, string surname, int age, string date)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.date = date;
        }

        public void ShowUser()
        {
            Console.WriteLine($"User {name} {surname} with login {login} and age {age} years has been registered on {date}");
        }
    }
}

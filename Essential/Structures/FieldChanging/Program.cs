using System;

namespace FieldChanging
{
    class Program
    {
        //When you pass a structure-type variable to a method as an argument or return a structure-type value from a method,
        //the whole instance of a structure type is copied. That can affect the performance of your code in high-performance
        //scenarios that involve large structure types. 
        public static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed from Program to MyClass";
            Console.WriteLine($"From myClassTaker method: {myClass.change} - {myClass.GetHashCode()}");
        }

        public static void StructTaker(MyStruct myStruct)
        {
            Console.WriteLine($"From myStructTaker method before changes: {myStruct.change} {myStruct.GetHashCode()}");
            myStruct.change = "changed from Program to MyStruct";
            Console.WriteLine($"From myStructTaker method: {myStruct.change} {myStruct.GetHashCode()}");
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.change = "not changed";

            MyStruct myStruct = new MyStruct();
            myStruct.change = "not changed";

            Console.WriteLine($"From myClass in Main: {myClass.change} - {myClass.GetHashCode()}");
            Console.WriteLine($"From myStruct in Main: {myStruct.change} {myStruct.GetHashCode()}");
            Console.WriteLine("");

            ClassTaker(myClass);
            StructTaker(myStruct);

            Console.WriteLine("");

            Console.WriteLine($"From myClass in Main: {myClass.change}  - {myClass.GetHashCode()}");
            Console.WriteLine($"From myStruct in Main: {myStruct.change} {myStruct.GetHashCode()}");

            Console.ReadKey();
        }
    }
}

using System;

namespace CustomArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            Console.WriteLine($"Capacity is: {myArrayList.Capacity}. Count is: {myArrayList.Count}");
            Console.WriteLine($"First item is: '{myArrayList[0]}'");

            int index = myArrayList.Add(DateTime.Now);
            Console.WriteLine($"Item was added under the index {index}. Was added the following info: {myArrayList[index]}");
            Console.WriteLine($"Capacity is: {myArrayList.Capacity}. Count is: {myArrayList.Count}");

            int index1 = myArrayList.Add(DateTime.Now);
            Console.WriteLine($"Item was added under the index {index1}. Was added the following info: {myArrayList[index1]}");
            Console.WriteLine($"Capacity is: {myArrayList.Capacity}. Count is: {myArrayList.Count}");

            int index2 = myArrayList.Add(DateTime.Now);
            Console.WriteLine($"Item was added under the index {index2}. Was added the following info: {myArrayList[index2]}");
            Console.WriteLine($"Capacity is: {myArrayList.Capacity}. Count is: {myArrayList.Count}");

            int index3 = myArrayList.Add(DateTime.Now);
            Console.WriteLine($"Item was added under the index {index3}. Was added the following info: {myArrayList[index3]}");
            Console.WriteLine($"Capacity is: {myArrayList.Capacity}. Count is: {myArrayList.Count}");

            int index4 = myArrayList.Add(DateTime.Now);
            Console.WriteLine($"Item was added under the index {index4}. Was added the following info: {myArrayList[index4]}");
            Console.WriteLine($"Capacity is: {myArrayList.Capacity}. Count is: {myArrayList.Count}");

            Console.ReadKey();
        }
    }
}

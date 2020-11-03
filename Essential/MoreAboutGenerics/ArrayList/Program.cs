using System;
using System.Collections;

namespace MyArrayList
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add("Hello");
            myArrayList.Add(DateTime.Now);
            myArrayList.Add(14);
            myArrayList.Add(true);
            myArrayList.Add(new Program()); //We will not be able to get information in that case. Any Object type element can be added to ArrayList 
                                            // and when we try to access we never know the initial type of elemeny added. Better to use generic collections for this.
                                            //Using the generic ArrayList will allow us not to cast the object when we are trying to get it out of the array.

            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.WriteLine(myArrayList[i]);
            }

            Console.ReadKey();
        }
    }
}

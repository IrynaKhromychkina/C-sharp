using System;

namespace List
{
    class MyList<T>
    {
        T[] myArray;
        public MyList(int capacity)
        {
            myArray = new T[capacity];
            Count = 0;
        }
        public void Add(T newItem)
        {
            if (Count < myArray.Length)
            {
                myArray[Count] = newItem;
                Count++;
            }
            else
            {
                Console.WriteLine("List max capacity reached. Item was not added.");
            }
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                {
                    return myArray[index];
                }
                else
                {
                    Console.WriteLine("Index is out of list range");
                    return default;
                }
            }
        }
        public int Count
        {
            get; private set;
        }
    }
}

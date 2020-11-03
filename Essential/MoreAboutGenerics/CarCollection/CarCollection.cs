using System;

namespace CarCollection
{
    class CarCollection<T> where T : Car, new()
    {
        T[] myCarPark;
        public CarCollection(int capacity)
        {
            myCarPark = new T[capacity];
            Count = 0;
        }
        public void Add(string model, int year)
        {
            if (Count < myCarPark.Length)
            {
                myCarPark[Count] = new T()
                {
                    CarModel = model,
                    CarYear = year
                };
                Count++;
            }
            else
            {
                Console.WriteLine("Max car park quantity is reached. Car was not added.");
            }
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                {
                    return myCarPark[index];
                }
                else
                {
                    Console.WriteLine("Index is out of car park scope");
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

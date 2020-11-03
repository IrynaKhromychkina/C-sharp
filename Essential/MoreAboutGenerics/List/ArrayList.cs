using System;

namespace CustomArrayList
{
    class ArrayList
    {
        const int defaultCapacity = 2;
        const int growthFactor = 2;

        Object[] myContainer;
        public ArrayList()
        {
            myContainer = new Object[defaultCapacity];
        }
        public virtual int Capacity
        {
            get { return myContainer.Length; }
            set { Array.Resize<object>(ref myContainer, value); }
        }
        public virtual int Count
        { get; private set; }
        public virtual int Add(object value)
        {
            if (Count == Capacity)
            {
                Capacity = Capacity * growthFactor;
            }
            myContainer[Count] = value;
            Count++;
            return Count - 1;
        }
        public object this[int index]
        {
            get
            {
                if (index >= 0 && index < Count)
                {
                    return myContainer[index];
                }
                else
                {
                    Console.WriteLine("Index is out of list range");
                    return default;
                }
            }
        }
    }
}


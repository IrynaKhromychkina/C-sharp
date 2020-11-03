using System;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary(int capacity)
        {
            keys = new TKey[capacity];
            values = new TValue[capacity];
            Count = 0;
        }
        public void Add(TKey key, TValue value)
        {
            if (Count < keys.Length)
            {
                keys[Count] = key;
                values[Count] = value;
                Count++;
                Console.WriteLine($"Item {key} - {value} was added");
            }
            else
            {
                Console.WriteLine("Maximum capacity reached. Item entered was not recorded");
            }
        }
        public TValue this[int index]
        {
            get
            {
                if (index < Count && index >= 0)
                {
                    return values[index];
                }
                Console.WriteLine("Index is out of dictionary range");
                return default;
            }
        }
        public int Count { private set; get; }
    }
}

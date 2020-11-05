using System.Collections;
using System.Collections.Generic;

namespace Dictionary
{
    internal class MyEnumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>
    {
        MyDictionary<TKey, TValue> dictionary;
        public KeyValuePair<TKey, TValue> Current
        {
            get 
            {
                TKey key = dictionary.keys[position];
                TValue value = dictionary[position];

                KeyValuePair<TKey, TValue> result = new KeyValuePair<TKey, TValue>(key, value);
                return result;
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public MyEnumerator(MyDictionary<TKey, TValue> myNumbers)
        {
            dictionary = myNumbers;
        }

        int position = -1;
        public bool MoveNext()
        {
            if (position < dictionary.Count - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace MyList
{
    static class Extensions
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] result = new T[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                result[i] = list[i];
            }
            return result;
        }

        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            return list.ToArray();
            /*T[] result = new T[list.Count()];
            int i = 0;
            foreach (T element in list)
            {
                result[i] = element;
                i++;
            }

            return result;*/
        }
    }
}

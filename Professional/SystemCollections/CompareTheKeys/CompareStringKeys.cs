using System.Collections;

namespace CompareTheKeys
{
    class CompareStringKeys : IEqualityComparer
    {
        public new bool Equals(object x, object y)
        {
            if (x == null || y == null || x.GetType() != y.GetType() || x is string)
            {
                return false;
            }

            return (string)x == (string)y;
        }

        public int GetHashCode(object obj)
        {
            return obj.GetHashCode();
        }
    }
}

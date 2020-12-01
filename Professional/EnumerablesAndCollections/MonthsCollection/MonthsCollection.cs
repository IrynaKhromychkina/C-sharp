namespace MonthsCollection
{
    class MonthsCollection
    {
        readonly Month[] months = new Month [12];

        public Month this [byte index]
        {
            get { return months[index]; }
            set { months[index] = value; }
        }

        sbyte position = -1;

        public bool MoveNext()
        {
            if(position < months.Length-1)
            {
                position++;
                return true;
            }

            Reset();
            return false;
        }

        void Reset ()
        {
            position = -1;
        }

        public Month Current
        {
            get { return months[position]; }
        }

        public MonthsCollection GetEnumerator()
        {
            return this;
        }
    }
}

namespace MonthsCollection
{
    class Month
    {
        public string Name { get; set; }
        public byte Number { get; set; }
        public byte Days { get; set; }

        public Month(string name, byte number, byte days)
        {
            Name = name;
            Number = number;
            Days = days;
        }
    }
}

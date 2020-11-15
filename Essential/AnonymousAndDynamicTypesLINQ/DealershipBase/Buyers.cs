namespace DealershipBase
{
    class Buyers
    {
        public string Model { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }

        public Buyers(string model, string name, int phoneNumber)
        {
            this.Model = model;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }
    }
}

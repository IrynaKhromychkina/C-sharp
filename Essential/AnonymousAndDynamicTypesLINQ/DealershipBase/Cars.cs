namespace DealershipBase
{
    public class Cars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public Cars(string brand, string model, string color, int year)
        {
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
            this.Year = year;
        }
    }
}

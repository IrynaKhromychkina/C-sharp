namespace HouseCloning
{
    class Owner
    {
        private string name;
        private string surname;

        public Owner(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public object Clone() => this.MemberwiseClone();
    }
}

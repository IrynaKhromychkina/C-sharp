using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassProgram
{
    class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public int Index
        {
            set { index = value; }
            get { return index; }
        }

        public string Country
        {
            set { country = value; }
            get { return country; }
        }

        public string City
        {
            set { city = value; }
            get { return city; }
        }

        public string Street
        {
            set { street = value; }
            get { return street; }
        }

        public int House
        {
            set { house = value; }
            get { return house; }
        }

        public int Apartment
        {
            set { apartment = value; }
            get { return apartment; }
        }
    }
}

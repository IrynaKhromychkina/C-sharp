using System;

namespace HouseCloning
{
    class House
    {
        private double floorSpace;
        private Owner houseOwner;

        public House(double floorSpace, Owner houseOwner)
        {
            this.floorSpace = floorSpace;
            this.houseOwner = houseOwner;
        }

        public double FloorSpace
        {
            get { return floorSpace; }
            set { floorSpace = value; }
        }

        public Owner HouseOwner
        {
            get { return houseOwner; }
            set { houseOwner = value; }
        }

        public House DeepClone() => new House(this.FloorSpace, this.HouseOwner.Clone() as Owner);

        public House Clone() => this.MemberwiseClone() as House;
    }
}

namespace Tetragon
{
    public class Tetragon : object
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private double sideD;

        public Tetragon(double sideA, double sideB, double sideC, double sideD)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.sideD = sideD;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Tetragon myTetragon = (Tetragon)obj;

            return ((sideA == myTetragon.sideA) && (sideB == myTetragon.sideB) && (sideC == myTetragon.sideC) && (sideD == myTetragon.sideD));
            //OR return (this.sideA.Equals(myTetragon.sideA) && this.sideB.Equals(myTetragon.sideB) && this.sideC.Equals(myTetragon.sideC) && this.sideD.Equals(myTetragon.sideD));
        }

        public override int GetHashCode()
        {
            int hashCode = 19;
            hashCode = hashCode * 37 + sideA.GetHashCode();
            hashCode = hashCode * 37 + sideB.GetHashCode();
            hashCode = hashCode * 37 + sideC.GetHashCode();
            hashCode = hashCode * 37 + sideD.GetHashCode();
            return hashCode;

        }
        public override string ToString()
        {
            return string.Format($"side A = {sideA}, side B = {sideB}, side C = {sideC}, side D = {sideD}");
        }
    }
}

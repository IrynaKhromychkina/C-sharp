namespace Point
{
    public struct Point
    {
        private int x;
        private int y;
        private int z;

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point operator +(Point firstPoint, Point secondPoint)
        {
            return new Point(firstPoint.x + secondPoint.x, firstPoint.y + secondPoint.y, firstPoint.z + secondPoint.z);
        }

        public override string ToString()
        {
            return string.Format($"[{this.x}, {this.y}, {this.z}]");
        }
    }
}

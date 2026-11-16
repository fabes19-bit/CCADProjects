namespace Assignment1_4
{
    // 1. Create a structure named "Point" and 2 data members: X and Y coordinate
    public struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}

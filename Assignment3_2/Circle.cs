using System;

namespace Assignment3_2
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = Math.Max(0, radius);
        }

        public double Area => Math.PI * Radius * Radius;

        public static double operator +(Circle c1, Circle c2)
        {
            if (c1 == null || c2 == null) return 0;
            return c1.Area + c2.Area;
        }

        public static double operator -(Circle c1, Circle c2)
        {
            if (c1 == null || c2 == null) return 0;
            return Math.Abs(c1.Area - c2.Area);
        }

        public override string ToString()
        {
            return $"Circle (Radius = {Radius:F2}, Area = {Area:F2})";
        }
    }
}

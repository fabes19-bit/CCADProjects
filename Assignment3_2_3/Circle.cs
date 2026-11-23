using System;

namespace Assignment3_2_3
{
    /// <summary>
    /// Circle class with overloaded + and - operators for calculating
    /// the sum and difference of the areas of two circles.
    /// </summary>
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = Math.Max(0, radius);
        }

        /// <summary>
        /// Calculates the area of the circle: pi * r^2
        /// </summary>
        public double Area => Math.PI * Radius * Radius;

        /// <summary>
        /// Overloaded '+' operator to add the areas of two circles.
        /// </summary>
        public static double operator +(Circle c1, Circle c2)
        {
            if (c1 == null || c2 == null) return 0;
            return c1.Area + c2.Area;
        }

        /// <summary>
        /// Overloaded '-' operator to calculate the difference between the areas of two circles.
        /// </summary>
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

using System;

namespace Assignment2_2
{
    /// <summary>
    /// Circle shape inheriting from abstract base class Shape.
    /// </summary>
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(int id, string name, string color, double radius)
            : base(id, name, color)
        {
            Radius = radius;
        }

        /// <summary>
        /// Overrides CalculateArea to compute the area of a circle (pi * r^2).
        /// </summary>
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Radius:      {Radius}");
            Console.WriteLine($"Area:        {CalculateArea():F2}");
        }
    }
}

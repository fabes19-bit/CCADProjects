using System;

namespace Assignment2_2
{
    /// <summary>
    /// Square shape inheriting from abstract base class Shape.
    /// </summary>
    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(int id, string name, string color, double side)
            : base(id, name, color)
        {
            Side = side;
        }

        /// <summary>
        /// Overrides CalculateArea to compute the area of a square (side * side).
        /// </summary>
        public override double CalculateArea()
        {
            return Side * Side;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Side Length: {Side}");
            Console.WriteLine($"Area:        {CalculateArea():F2}");
        }
    }
}

namespace Assignment2_2
{
    /// <summary>
    /// Abstract base class representing a geometric Shape.
    /// </summary>
    public abstract class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        protected Shape(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        /// <summary>
        /// Abstract method to calculate the area of the shape.
        /// Must be overridden by derived shape classes.
        /// </summary>
        public abstract double CalculateArea();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Shape ID:    {Id}");
            Console.WriteLine($"Shape Name:  {Name}");
            Console.WriteLine($"Shape Color: {Color}");
        }
    }
}

using System;

namespace Assignment2_1_1
{
    /// <summary>
    /// Derived class representing a Terrier, inheriting from Dog.
    /// </summary>
    public class Terrier : Dog
    {
        // Property specific to Terrier
        public string DiggingInstinct { get; set; } // e.g., "High", "Tenacious"

        // Constructors
        public Terrier() : base()
        {
            BreedGroup = "Terrier";
            DiggingInstinct = "High";
        }

        public Terrier(string name, int age, string ownerName, bool isVaccinated, string diggingInstinct)
            : base(name, age, ownerName, "Terrier", isVaccinated)
        {
            DiggingInstinct = diggingInstinct;
        }

        // Terrier-specific behavior
        public void Dig()
        {
            Console.WriteLine($"{Name} is energetically digging into the ground with {DiggingInstinct} instinct!");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"      Digging Instinct: {DiggingInstinct}");
        }
    }
}

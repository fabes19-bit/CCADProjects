using System;

namespace Assignment2_1
{
    public class Terrier : Dog
    {
        public string DiggingInstinct { get; set; }

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

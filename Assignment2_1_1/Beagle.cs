using System;

namespace Assignment2_1_1
{
    /// <summary>
    /// Specific breed derived from Hound.
    /// </summary>
    public class Beagle : Hound
    {
        // Property specific to Beagle
        public double EarLengthInches { get; set; }

        // Constructors
        public Beagle() : base()
        {
            TrackingAbility = "Scent";
            EarLengthInches = 7.5;
        }

        public Beagle(string name, int age, string ownerName, bool isVaccinated, double earLengthInches)
            : base(name, age, ownerName, isVaccinated, "Scent")
        {
            EarLengthInches = earLengthInches;
        }

        // Beagle-specific behavior
        public void SniffOutTrack()
        {
            Console.WriteLine($"{Name} puts their nose to the trail with floppy {EarLengthInches}\" ears flapping!");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"      Breed: Beagle (Ear Length: {EarLengthInches} inches)");
        }
    }
}

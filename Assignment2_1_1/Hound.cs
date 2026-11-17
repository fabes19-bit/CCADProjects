using System;

namespace Assignment2_1_1
{
    /// <summary>
    /// Derived class representing a Hound, inheriting from Dog.
    /// </summary>
    public class Hound : Dog
    {
        // Property specific to Hound
        public string TrackingAbility { get; set; } // e.g. "Scent" or "Sight"

        // Constructors
        public Hound() : base()
        {
            BreedGroup = "Hound";
            TrackingAbility = "Scent";
        }

        public Hound(string name, int age, string ownerName, bool isVaccinated, string trackingAbility)
            : base(name, age, ownerName, "Hound", isVaccinated)
        {
            TrackingAbility = trackingAbility;
        }

        // Hound-specific behavior
        public void Bay()
        {
            Console.WriteLine($"{Name} lets out a deep, melodious hound bay: Awooooo!");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"      Tracking Type: {TrackingAbility} Hound");
        }
    }
}

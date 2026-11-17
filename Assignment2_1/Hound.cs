using System;

namespace Assignment2_1
{
    public class Hound : Dog
    {
        public string TrackingAbility { get; set; }

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

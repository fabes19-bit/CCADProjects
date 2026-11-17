using System;

namespace Assignment2_1_1
{
    /// <summary>
    /// Specific breed derived from Terrier.
    /// </summary>
    public class WelshTerrier : Terrier
    {
        // Property specific to Welsh Terrier
        public string CoatPattern { get; set; } // e.g., "Black and Tan wirehaired"

        // Constructors
        public WelshTerrier() : base()
        {
            CoatPattern = "Black and Tan Wire";
        }

        public WelshTerrier(string name, int age, string ownerName, bool isVaccinated, string diggingInstinct, string coatPattern)
            : base(name, age, ownerName, isVaccinated, diggingInstinct)
        {
            CoatPattern = coatPattern;
        }

        // Welsh Terrier-specific behavior
        public void HuntVermin()
        {
            Console.WriteLine($"{Name} is fearlessly scouring the brush in true Welsh Terrier fashion!");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"      Breed: Welsh Terrier (Coat: {CoatPattern})");
        }
    }
}

using System;

namespace Assignment2_1
{
    public class WelshTerrier : Terrier
    {
        public string CoatPattern { get; set; }

        public WelshTerrier() : base()
        {
            CoatPattern = "Black and Tan Wire";
        }

        public WelshTerrier(string name, int age, string ownerName, bool isVaccinated, string diggingInstinct, string coatPattern)
            : base(name, age, ownerName, isVaccinated, diggingInstinct)
        {
            CoatPattern = coatPattern;
        }

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

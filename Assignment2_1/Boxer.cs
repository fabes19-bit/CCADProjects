using System;

namespace Assignment2_1
{
    public class Boxer : Working
    {
        public int EnergyLevel { get; set; }

        public Boxer() : base()
        {
            DutyType = "Guard and Companion";
            EnergyLevel = 10;
        }

        public Boxer(string name, int age, string ownerName, bool isVaccinated, string dutyType, int energyLevel)
            : base(name, age, ownerName, isVaccinated, dutyType)
        {
            EnergyLevel = energyLevel;
        }

        public void Box()
        {
            Console.WriteLine($"{Name} stands on hind legs and playfully bats front paws (boxing style)! Energy: {EnergyLevel}/10.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"      Breed: Boxer (Energy Level: {EnergyLevel}/10)");
        }
    }
}

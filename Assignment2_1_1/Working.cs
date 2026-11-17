using System;

namespace Assignment2_1_1
{
    /// <summary>
    /// Derived class representing a Working Dog, inheriting from Dog.
    /// </summary>
    public class Working : Dog
    {
        // Property specific to Working dog
        public string DutyType { get; set; } // e.g. "Guard", "Search and Rescue", "Service"

        // Constructors
        public Working() : base()
        {
            BreedGroup = "Working";
            DutyType = "General Utility";
        }

        public Working(string name, int age, string ownerName, bool isVaccinated, string dutyType)
            : base(name, age, ownerName, "Working", isVaccinated)
        {
            DutyType = dutyType;
        }

        // Working-specific behavior
        public void PerformDuty()
        {
            Console.WriteLine($"{Name} is faithfully executing duty: '{DutyType}'!");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"      Assigned Duty: {DutyType}");
        }
    }
}

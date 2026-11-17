using System;

namespace Assignment2_1
{
    public class Working : Dog
    {
        public string DutyType { get; set; }

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

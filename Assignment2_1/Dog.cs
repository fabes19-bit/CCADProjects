using System;

namespace Assignment2_1
{
    public class Dog : Pet
    {
        public string BreedGroup { get; set; }
        public bool IsVaccinated { get; set; }

        public Dog() : base()
        {
            BreedGroup = "Canine";
            IsVaccinated = false;
        }

        public Dog(string name, int age, string ownerName, string breedGroup, bool isVaccinated)
            : base(name, age, ownerName)
        {
            BreedGroup = breedGroup;
            IsVaccinated = isVaccinated;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} barks: Woof! Woof!");
        }

        public void Fetch(string item)
        {
            Console.WriteLine($"{Name} runs and fetches the {item} happily!");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"      Breed Group: {BreedGroup}, Vaccinated: {IsVaccinated}");
        }
    }
}

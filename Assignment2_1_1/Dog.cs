using System;

namespace Assignment2_1_1
{
    /// <summary>
    /// Derived class representing a Dog, inheriting from Pet.
    /// </summary>
    public class Dog : Pet
    {
        // Additional properties specific to Dog
        public string BreedGroup { get; set; }
        public bool IsVaccinated { get; set; }

        // Constructors
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

        // Overriding base method
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} barks: Woof! Woof!");
        }

        // Dog-specific method
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

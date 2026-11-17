using System;

namespace Assignment2_1_1
{
    /// <summary>
    /// Base class representing a general Pet.
    /// </summary>
    public class Pet
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string OwnerName { get; set; }

        // Constructors
        public Pet()
        {
            Name = "Unknown Pet";
            Age = 0;
            OwnerName = "None";
        }

        public Pet(string name, int age, string ownerName)
        {
            Name = name;
            Age = age;
            OwnerName = ownerName;
        }

        // Virtual methods for polymorphism
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a generic pet sound.");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"[Pet] Name: {Name}, Age: {Age}, Owner: {OwnerName}");
        }
    }
}

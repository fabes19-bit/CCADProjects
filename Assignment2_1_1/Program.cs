using System;
using System.Collections.Generic;

namespace Assignment2_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("   Assignment 2.1 - Question 1: Class Hierarchy (Pet/Dog) ");
            Console.WriteLine("==========================================================\n");

            Console.WriteLine("Class Hierarchy Structure:");
            Console.WriteLine("                  [ Pet ]");
            Console.WriteLine("                     ^");
            Console.WriteLine("                  [ Dog ]");
            Console.WriteLine("             /       |       \\");
            Console.WriteLine("        [Hound]  [Terrier]  [Working]");
            Console.WriteLine("           ^         ^          ^");
            Console.WriteLine("       [Beagle]   [Welsh]    [Boxer]");
            Console.WriteLine("                 [Terrier]          \n");

            // Instantiating specific concrete leaf breeds
            Beagle beagle = new Beagle("Copper", 4, "Fabian", true, 8.2);
            WelshTerrier terrier = new WelshTerrier("Rusty", 3, "Sarah", true, "Relentless", "Black & Tan Wiry");
            Boxer boxer = new Boxer("Rocky", 5, "Mike", true, "Estate Guard", 10);

            // Polymorphic collection of Pets
            List<Pet> pets = new List<Pet> { beagle, terrier, boxer };

            Console.WriteLine("--- Demonstrating Polymorphism & Info Display ---");
            foreach (Pet p in pets)
            {
                p.DisplayInfo();
                p.MakeSound();
                Console.WriteLine();
            }

            Console.WriteLine("--- Demonstrating Breed-Specific Methods ---");
            Console.Write("Beagle behavior:       ");
            beagle.SniffOutTrack();
            beagle.Bay();

            Console.Write("Welsh Terrier behavior:");
            terrier.Dig();
            terrier.HuntVermin();

            Console.Write("Boxer behavior:        ");
            boxer.PerformDuty();
            boxer.Box();

            Console.WriteLine("\nAll class files verified successfully!");
        }
    }
}

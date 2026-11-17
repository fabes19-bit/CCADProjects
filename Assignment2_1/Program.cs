using System;
using System.Collections.Generic;

namespace Assignment2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n==========================================================");
                Console.WriteLine("          10975 Programming - Assignments 2.1              ");
                Console.WriteLine("==========================================================");
                Console.WriteLine("1. Question 1: Class Hierarchy (Pet -> Dog -> Breeds)");
                Console.WriteLine("2. Question 2: Maths Method Overloading");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option (1-3): ");

                string choice = Console.ReadLine()?.Trim() ?? "";

                switch (choice)
                {
                    case "1":
                        RunClassHierarchyDemo();
                        break;
                    case "2":
                        RunMathsMenu();
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please enter 1, 2, or 3.");
                        break;
                }
            }
        }

        static void RunClassHierarchyDemo()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("  Question 1: Class Hierarchy Demonstration");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Hierarchy Structure:");
            Console.WriteLine("                  [ Pet ]");
            Console.WriteLine("                     ^");
            Console.WriteLine("                  [ Dog ]");
            Console.WriteLine("             /       |       \\");
            Console.WriteLine("        [Hound]  [Terrier]  [Working]");
            Console.WriteLine("           ^         ^          ^");
            Console.WriteLine("       [Beagle]   [Welsh]    [Boxer]");
            Console.WriteLine("                 [Terrier]          \n");

            Beagle beagle = new Beagle("Copper", 4, "Fabian", true, 8.2);
            WelshTerrier terrier = new WelshTerrier("Rusty", 3, "Sarah", true, "Relentless", "Black & Tan Wiry");
            Boxer boxer = new Boxer("Rocky", 5, "Mike", true, "Estate Guard", 10);

            List<Pet> pets = new List<Pet> { beagle, terrier, boxer };

            Console.WriteLine("--- Polymorphism & Info Display ---");
            foreach (Pet p in pets)
            {
                p.DisplayInfo();
                p.MakeSound();
                Console.WriteLine();
            }

            Console.WriteLine("--- Breed-Specific Methods ---");
            Console.Write("Beagle:        ");
            beagle.SniffOutTrack();
            beagle.Bay();

            Console.Write("Welsh Terrier: ");
            terrier.Dig();
            terrier.HuntVermin();

            Console.Write("Boxer:         ");
            boxer.PerformDuty();
            boxer.Box();
        }

        static void RunMathsMenu()
        {
            bool inMaths = true;

            while (inMaths)
            {
                Console.WriteLine("\n----------------------------------------------------------");
                Console.WriteLine("  Question 2: Maths Method Overloading");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("  a. Add(int num1, int num2)");
                Console.WriteLine("  b. Add(decimal num1, decimal num2, decimal num3)");
                Console.WriteLine("  c. Multiply(float num1, float num2)");
                Console.WriteLine("  d. Multiply(float num1, float num2, float num3)");
                Console.WriteLine("  e. Return to Main Menu");
                Console.Write("Select an operation (a-e): ");

                string choice = Console.ReadLine()?.Trim().ToLower() ?? "";

                switch (choice)
                {
                    case "a":
                        Console.WriteLine("\n--- a. Add(int num1, int num2) ---");
                        Console.Write("Enter first integer: ");
                        int i1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter second integer: ");
                        int i2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Result: Maths.Add({i1}, {i2}) = {Maths.Add(i1, i2)}");
                        break;

                    case "b":
                        Console.WriteLine("\n--- b. Add(decimal num1, decimal num2, decimal num3) ---");
                        Console.Write("Enter first decimal: ");
                        decimal d1 = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Enter second decimal: ");
                        decimal d2 = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Enter third decimal: ");
                        decimal d3 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"Result: Maths.Add({d1}, {d2}, {d3}) = {Maths.Add(d1, d2, d3)}");
                        break;

                    case "c":
                        Console.WriteLine("\n--- c. Multiply(float num1, float num2) ---");
                        Console.Write("Enter first float: ");
                        float f1 = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Enter second float: ");
                        float f2 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Result: Maths.Multiply({f1}f, {f2}f) = {Maths.Multiply(f1, f2)}");
                        break;

                    case "d":
                        Console.WriteLine("\n--- d. Multiply(float num1, float num2, float num3) ---");
                        Console.Write("Enter first float: ");
                        float m1 = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Enter second float: ");
                        float m2 = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Enter third float: ");
                        float m3 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Result: Maths.Multiply({m1}f, {m2}f, {m3}f) = {Maths.Multiply(m1, m2, m3)}");
                        break;

                    case "e":
                        inMaths = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose a, b, c, d, or e.");
                        break;
                }
            }
        }
    }
}

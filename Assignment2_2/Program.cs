using System;

namespace Assignment2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            Console.WriteLine("==========================================================");
            Console.WriteLine("       Assignment 2.2: Abstract Shape Area Calculator     ");
            Console.WriteLine("==========================================================");

            while (running)
            {
                Console.WriteLine("\nSelect a shape to calculate its area:");
                Console.WriteLine("  1. Circle");
                Console.WriteLine("  2. Square");
                Console.WriteLine("  3. Exit");
                Console.Write("Enter your choice (1-3): ");

                string choice = Console.ReadLine()?.Trim() ?? "";

                if (choice == "3")
                {
                    running = false;
                    Console.WriteLine("Exiting program. Goodbye!");
                    continue;
                }

                if (choice != "1" && choice != "2")
                {
                    Console.WriteLine("Invalid selection. Please enter 1, 2, or 3.");
                    continue;
                }

                // Collect common Shape properties from user (no hard-coded values)
                Console.Write("Enter Shape ID (integer): ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Shape Name: ");
                string name = Console.ReadLine() ?? "";

                Console.Write("Enter Shape Color: ");
                string color = Console.ReadLine() ?? "";

                Shape shape;

                if (choice == "1")
                {
                    Console.Write("Enter Radius of the Circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    shape = new Circle(id, name, color, radius);
                }
                else
                {
                    Console.Write("Enter Side length of the Square: ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    shape = new Square(id, name, color, side);
                }

                Console.WriteLine("\n--- Calculated Shape Details ---");
                shape.DisplayInfo();
                Console.WriteLine("--------------------------------");
            }
        }
    }
}

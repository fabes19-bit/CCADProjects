using System;

namespace Assignment3_2_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("   Assignment 3.2 - Question 3: Circle Operator Overload  ");
            Console.WriteLine("==========================================================\n");

            Console.WriteLine("This program overloads the '+' and '-' operators to compute");
            Console.WriteLine("the sum and difference of the areas of two Circle objects.\n");

            double r1 = ReadRadius("Enter radius for Circle 1: ");
            double r2 = ReadRadius("Enter radius for Circle 2: ");

            Circle c1 = new Circle(r1);
            Circle c2 = new Circle(r2);

            Console.WriteLine("\n--- Circle Details ---");
            Console.WriteLine($"Circle 1: Radius = {c1.Radius:F2}, Area = {c1.Area:F2}");
            Console.WriteLine($"Circle 2: Radius = {c2.Radius:F2}, Area = {c2.Area:F2}");

            // Using overloaded operators
            double addedArea = c1 + c2;
            double areaDifference = c1 - c2;

            Console.WriteLine("\n--- Operator Overloading Results ---");
            Console.WriteLine($"c1 + c2 (Sum of Areas)        = {addedArea:F2}");
            Console.WriteLine($"c1 - c2 (Difference of Areas) = {areaDifference:F2}");
        }

        private static double ReadRadius(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (double.TryParse(input?.Trim(), out double val) && val >= 0)
                {
                    return val;
                }
                Console.WriteLine("Invalid radius. Please enter a non-negative numeric value.\n");
            }
        }
    }
}

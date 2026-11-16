using System;

namespace Assignment1_4_1
{
    // 1. Create a structure named "Point" and 2 data members: X and Y coordinate
    public struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("    Assignment 1.4 - Question 1: Point Structure  ");
            Console.WriteLine("==================================================");
            Console.WriteLine("This program determines if P2 is to the right or left");
            Console.WriteLine("of P1 or on the same axis by comparing X coordinates.\n");

            bool keepRunning = true;

            while (keepRunning)
            {
                // Declare 2 points: P1 and P2
                Point P1 = new Point();
                Point P2 = new Point();

                Console.WriteLine("Enter coordinates for Point P1:");
                Console.Write("  Enter P1.X: ");
                P1.X = Convert.ToDouble(Console.ReadLine());
                Console.Write("  Enter P1.Y: ");
                P1.Y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nEnter coordinates for Point P2:");
                Console.Write("  Enter P2.X: ");
                P2.X = Convert.ToDouble(Console.ReadLine());
                Console.Write("  Enter P2.Y: ");
                P2.Y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n--- Comparison Output ---");
                Console.WriteLine($"Point P1 coordinates: {P1}");
                Console.WriteLine($"Point P2 coordinates: {P2}");

                // Determine if P2 is to the right or left of P1 or on same axis
                if (P2.X > P1.X)
                {
                    Console.WriteLine($"-> P2 is to the RIGHT of P1 (P2.X [{P2.X}] > P1.X [{P1.X}]).");
                }
                else if (P2.X < P1.X)
                {
                    Console.WriteLine($"-> P2 is to the LEFT of P1 (P1 is to the right of P2, since P1.X [{P1.X}] > P2.X [{P2.X}]).");
                }
                else
                {
                    Console.WriteLine($"-> Points P1 and P2 are on the SAME AXIS (P1.X == P2.X == {P1.X}).");
                }

                Console.Write("\nWould you like to test another pair of points? (y/n): ");
                string? response = Console.ReadLine()?.Trim().ToLower();
                if (response != "y" && response != "yes")
                {
                    keepRunning = false;
                    Console.WriteLine("Goodbye!");
                }
                Console.WriteLine();
            }
        }
    }
}

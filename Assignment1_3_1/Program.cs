using System;

namespace Assignment1_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\n--- Area Calculator Menu ---");
                Console.WriteLine("1. Triangle");
                Console.WriteLine("2. Square");
                Console.WriteLine("3. Rectangle");
                Console.WriteLine("4. Exit");
                Console.Write("Select a shape (1-4): ");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        CalculateTriangleArea();
                        break;
                    case "2":
                        CalculateSquareArea();
                        break;
                    case "3":
                        CalculateRectangleArea();
                        break;
                    case "4":
                        keepRunning = false;
                        Console.WriteLine("Exiting program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");
                        break;
                }
            }
        }

        static void CalculateTriangleArea()
        {
            Console.Write("Enter the base of the triangle: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the triangle: ");
            double h = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * b * h;
            Console.WriteLine($"Triangle Area = {area}");
        }

        static void CalculateSquareArea()
        {
            Console.Write("Enter the side length of the square: ");
            double side = Convert.ToDouble(Console.ReadLine());

            double area = side * side;
            Console.WriteLine($"Square Area = {area}");
        }

        static void CalculateRectangleArea()
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;
            Console.WriteLine($"Rectangle Area = {area}");
        }
    }
}
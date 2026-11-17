using System;

namespace Assignment2_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            Console.WriteLine("==========================================================");
            Console.WriteLine("    Assignment 2.1 - Question 2: Method Overloading       ");
            Console.WriteLine("==========================================================");

            while (running)
            {
                Console.WriteLine("\nChoose a Maths method to call:");
                Console.WriteLine("  a. Add(int num1, int num2)");
                Console.WriteLine("  b. Add(decimal num1, decimal num2, decimal num3)");
                Console.WriteLine("  c. Multiply(float num1, float num2)");
                Console.WriteLine("  d. Multiply(float num1, float num2, float num3)");
                Console.WriteLine("  e. Exit");
                Console.Write("Enter your choice (a, b, c, d, or e): ");

                string choice = Console.ReadLine()?.Trim().ToLower() ?? "";

                switch (choice)
                {
                    case "a":
                        CallAddInt();
                        break;
                    case "b":
                        CallAddDecimal();
                        break;
                    case "c":
                        CallMultiplyTwoFloats();
                        break;
                    case "d":
                        CallMultiplyThreeFloats();
                        break;
                    case "e":
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a, b, c, d, or e.");
                        break;
                }
            }
        }

        static void CallAddInt()
        {
            Console.WriteLine("\n--- a. Add(int num1, int num2) ---");
            Console.Write("Enter first integer (num1): ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer (num2): ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int result = Maths.Add(n1, n2);
            Console.WriteLine($"Result: Maths.Add({n1}, {n2}) = {result}");
        }

        static void CallAddDecimal()
        {
            Console.WriteLine("\n--- b. Add(decimal num1, decimal num2, decimal num3) ---");
            Console.Write("Enter first decimal (num1): ");
            decimal n1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter second decimal (num2): ");
            decimal n2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter third decimal (num3): ");
            decimal n3 = Convert.ToDecimal(Console.ReadLine());

            decimal result = Maths.Add(n1, n2, n3);
            Console.WriteLine($"Result: Maths.Add({n1}, {n2}, {n3}) = {result}");
        }

        static void CallMultiplyTwoFloats()
        {
            Console.WriteLine("\n--- c. Multiply(float num1, float num2) ---");
            Console.Write("Enter first float (num1): ");
            float n1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter second float (num2): ");
            float n2 = Convert.ToSingle(Console.ReadLine());

            float result = Maths.Multiply(n1, n2);
            Console.WriteLine($"Result: Maths.Multiply({n1}f, {n2}f) = {result}");
        }

        static void CallMultiplyThreeFloats()
        {
            Console.WriteLine("\n--- d. Multiply(float num1, float num2, float num3) ---");
            Console.Write("Enter first float (num1): ");
            float n1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter second float (num2): ");
            float n2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter third float (num3): ");
            float n3 = Convert.ToSingle(Console.ReadLine());

            float result = Maths.Multiply(n1, n2, n3);
            Console.WriteLine($"Result: Maths.Multiply({n1}f, {n2}f, {n3}f) = {result}");
        }
    }
}

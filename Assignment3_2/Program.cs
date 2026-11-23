using System;

namespace Assignment3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n==========================================================");
                Console.WriteLine("          20483 Programming in C# - Assignments 3.2       ");
                Console.WriteLine("==========================================================");
                Console.WriteLine("1. Question 1: 2D Array Matrix Display");
                Console.WriteLine("2. Exit");
                Console.Write("Select an option (1-2): ");

                string choice = Console.ReadLine()?.Trim() ?? "";

                switch (choice)
                {
                    case "1":
                        RunQuestion1();
                        break;
                    case "2":
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please enter 1 or 2.");
                        break;
                }
            }
        }

        /// <summary>
        /// Question 1: Create a 2D array to store integers and print them in matrix format with proper formatting.
        /// Example:
        /// | 2 | 3 | 4 |
        /// | 1 | 4 | 6 |
        /// </summary>
        static void RunQuestion1()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("  Question 1: 2D Array Matrix Display");
            Console.WriteLine("----------------------------------------------------------");

            int[,] sample = {
                { 2, 3, 4 },
                { 1, 4, 6 }
            };

            Console.WriteLine("Assignment Sample Matrix:");
            PrintMatrix(sample);

            Console.Write("\nWould you like to input a custom matrix? (y/n): ");
            string response = Console.ReadLine()?.Trim().ToLower() ?? "";

            if (response == "y" || response == "yes")
            {
                Console.Write("Enter number of rows: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number of columns: ");
                int cols = Convert.ToInt32(Console.ReadLine());

                int[,] custom = new int[rows, cols];

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        Console.Write($"Element [{r},{c}]: ");
                        custom[r, c] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nCustom Matrix:");
                PrintMatrix(custom);
            }
        }

        public static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                Console.Write("|");
                for (int c = 0; c < cols; c++)
                {
                    Console.Write($" {matrix[r, c]} |");
                }
                Console.WriteLine();
            }
        }
    }
}

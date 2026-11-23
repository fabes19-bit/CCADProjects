using System;
using System.Collections.Generic;

namespace Assignment3_2
{
    internal class Program
    {
        private static readonly Queue<int> tokenQueue = new Queue<int>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n==========================================================");
                Console.WriteLine("          20483 Programming in C# - Assignments 3.2       ");
                Console.WriteLine("==========================================================");
                Console.WriteLine("1. Question 1: 2D Array Matrix Display");
                Console.WriteLine("2. Question 2: Addition of Two Matrices");
                Console.WriteLine("3. Run Both Questions Sequentially");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");

                string choice = Console.ReadLine()?.Trim() ?? "";

                switch (choice)
                {
                    case "1":
                        RunQuestion1();
                        break;
                    case "2":
                        RunQuestion2();
                        break;
                    case "3":
                        RunQuestion1();
                        Console.WriteLine();
                        RunQuestion2();
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please enter 1-4.");
                        break;
                }
            }
        }

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
            PrintFormattedMatrix(sample);

            Console.Write("\nWould you like to input a custom matrix? (y/n): ");
            string response = Console.ReadLine()?.Trim().ToLower() ?? "";

            if (response == "y" || response == "yes")
            {
                int rows = ReadPositiveInt("Enter number of rows: ");
                int cols = ReadPositiveInt("Enter number of columns: ");

                int[,] custom = new int[rows, cols];

                Console.WriteLine($"\nEnter elements for a {rows}x{cols} matrix (enter one-by-one or separated by spaces):");
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        custom[r, c] = ReadElement($"Element [{r},{c}]: ");
                    }
                }

                Console.WriteLine("\nCustom Matrix:");
                PrintFormattedMatrix(custom);
            }
        }

        public static void PrintFormattedMatrix(int[,] matrix)
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

        static void RunQuestion2()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("  Question 2: Addition of Two Matrices");
            Console.WriteLine("----------------------------------------------------------");

            int size = ReadMatrixSize("Input the size of the square matrix (less than 5): ");

            int[,] first = new int[size, size];
            int[,] second = new int[size, size];
            int[,] sum = new int[size, size];

            Console.WriteLine("\nInput elements in the first matrix :");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    first[i, j] = ReadElement($"element - [{i}],[{j}] : ");
                }
            }

            Console.WriteLine("\nInput elements in the second matrix :");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    second[i, j] = ReadElement($"element - [{i}],[{j}] : ");
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sum[i, j] = first[i, j] + second[i, j];
                }
            }

            Console.WriteLine("\nThe First matrix is:");
            PrintSimpleMatrix(first);

            Console.WriteLine("\nThe Second matrix is :");
            PrintSimpleMatrix(second);

            Console.WriteLine("\nThe Addition of two matrix is :");
            PrintSimpleMatrix(sum);
        }

        public static void PrintSimpleMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int ReadMatrixSize(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (int.TryParse(input?.Trim(), out int val) && val > 0 && val < 5)
                {
                    return val;
                }
                Console.WriteLine("Invalid size. Please enter a positive integer less than 5 (e.g., 2, 3, or 4).\n");
            }
        }

        private static int ReadPositiveInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (int.TryParse(input?.Trim(), out int val) && val > 0)
                {
                    return val;
                }
                Console.WriteLine("Please enter a valid positive integer.\n");
            }
        }

        private static int ReadElement(string prompt)
        {
            while (tokenQueue.Count == 0)
            {
                Console.Write(prompt);
                string? line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string part in parts)
                {
                    if (int.TryParse(part, out int val))
                    {
                        tokenQueue.Enqueue(val);
                    }
                }
            }

            return tokenQueue.Dequeue();
        }
    }
}

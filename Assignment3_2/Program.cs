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
            PrintFormattedMatrix(sample);

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

        /// <summary>
        /// Question 2: Addition of two Matrices of the same size.
        /// </summary>
        static void RunQuestion2()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("  Question 2: Addition of Two Matrices");
            Console.WriteLine("----------------------------------------------------------");

            Console.Write("Input the size of the square matrix (less than 5): ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size <= 0 || size >= 5)
            {
                Console.WriteLine("Size must be positive and less than 5.");
                return;
            }

            int[,] first = new int[size, size];
            int[,] second = new int[size, size];
            int[,] sum = new int[size, size];

            Console.WriteLine("Input elements in the first matrix :");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    first[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Input elements in the second matrix :");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    second[i, j] = Convert.ToInt32(Console.ReadLine());
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
    }
}

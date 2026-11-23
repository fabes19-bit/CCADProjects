using System;

namespace Assignment3_2_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("   Assignment 3.2 - Question 1: 2D Array Matrix Format    ");
            Console.WriteLine("==========================================================\n");

            // 1. Declare and initialize 2D integer array from assignment example
            int[,] sampleMatrix = {
                { 2, 3, 4 },
                { 1, 4, 6 }
            };

            Console.WriteLine("--- Example Matrix Output ---");
            PrintMatrix(sampleMatrix);

            // 2. Interactive user-defined matrix
            Console.WriteLine("\n--- Create Your Own 2D Matrix ---");
            Console.Write("Enter number of rows (or 0 to exit): ");
            if (int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
            {
                Console.Write("Enter number of columns: ");
                if (int.TryParse(Console.ReadLine(), out int cols) && cols > 0)
                {
                    int[,] userMatrix = new int[rows, cols];

                    Console.WriteLine($"\nEnter elements for a {rows}x{cols} matrix:");
                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < cols; c++)
                        {
                            Console.Write($"Element [{r},{c}]: ");
                            userMatrix[r, c] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    Console.WriteLine("\nFormatted Matrix:");
                    PrintMatrix(userMatrix);
                }
            }
        }

        /// <summary>
        /// Prints a 2D rectangular array in matrix format (| x | y | z |)
        /// using GetLength(0) for rows and GetLength(1) for columns.
        /// </summary>
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

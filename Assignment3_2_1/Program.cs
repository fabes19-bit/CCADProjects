using System;
using System.Collections.Generic;

namespace Assignment3_2_1
{
    public class Program
    {
        private static readonly Queue<int> tokenQueue = new Queue<int>();

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

            // 2. Interactive user-defined matrix with crash-proof input handling
            Console.WriteLine("\n--- Create Your Own 2D Matrix ---");
            Console.Write("Enter number of rows (or 0 to exit): ");
            string? rInput = Console.ReadLine();

            if (int.TryParse(rInput?.Trim(), out int rows) && rows > 0)
            {
                Console.Write("Enter number of columns: ");
                string? cInput = Console.ReadLine();

                if (int.TryParse(cInput?.Trim(), out int cols) && cols > 0)
                {
                    int[,] userMatrix = new int[rows, cols];

                    Console.WriteLine($"\nEnter elements for a {rows}x{cols} matrix (enter one-by-one or all on one line):");
                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < cols; c++)
                        {
                            userMatrix[r, c] = ReadElement($"Element [{r},{c}]: ");
                        }
                    }

                    Console.WriteLine("\nFormatted Matrix:");
                    PrintMatrix(userMatrix);
                }
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

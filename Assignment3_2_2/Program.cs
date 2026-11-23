using System;
using System.Collections.Generic;

namespace Assignment3_2_2
{
    public class Program
    {
        private static readonly Queue<int> tokenQueue = new Queue<int>();

        public static void Main(string[] args)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("    Assignment 3.2 - Question 2: Matrix Addition          ");
            Console.WriteLine("==========================================================\n");

            int size = ReadSize("Input the size of the square matrix (less than 5): ");

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

            // Perform element-wise addition: sum[i, j] = first[i, j] + second[i, j]
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sum[i, j] = first[i, j] + second[i, j];
                }
            }

            Console.WriteLine("\nThe First matrix is:");
            PrintMatrix(first);

            Console.WriteLine("\nThe Second matrix is :");
            PrintMatrix(second);

            Console.WriteLine("\nThe Addition of two matrix is :");
            PrintMatrix(sum);
        }

        /// <summary>
        /// Reads the square matrix size safely with validation (must be > 0 and < 5).
        /// </summary>
        private static int ReadSize(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();

                if (int.TryParse(input?.Trim(), out int size) && size > 0 && size < 5)
                {
                    return size;
                }

                Console.WriteLine("Invalid size. Please enter a positive integer less than 5 (e.g. 2, 3, or 4).\n");
            }
        }

        /// <summary>
        /// Safely reads a matrix integer element.
        /// Supports both one-by-one entry (e.g. typing 1 then Enter)
        /// and batch entry (e.g. typing "1 2 3 4" on a single line).
        /// Never crashes on empty inputs or invalid characters.
        /// </summary>
        private static int ReadElement(string prompt)
        {
            while (tokenQueue.Count == 0)
            {
                Console.Write(prompt);
                string? line = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts = line.Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string part in parts)
                {
                    if (int.TryParse(part, out int val))
                    {
                        tokenQueue.Enqueue(val);
                    }
                    else
                    {
                        Console.WriteLine($"  Note: '{part}' is not a valid integer and was ignored.");
                    }
                }
            }

            return tokenQueue.Dequeue();
        }

        public static void PrintMatrix(int[,] matrix)
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

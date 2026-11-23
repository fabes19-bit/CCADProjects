using System;

namespace Assignment3_2_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("    Assignment 3.2 - Question 2: Matrix Addition          ");
            Console.WriteLine("==========================================================\n");

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

            // Perform element-wise matrix addition: sum[i, j] = first[i, j] + second[i, j]
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

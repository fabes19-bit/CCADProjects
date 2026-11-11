using System;

namespace Assignment1_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to store in the array :");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine($"Input {n} number of elements in the array :");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"element - {i} : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nThe values store into the array are:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine("\nThe values store into the array in reverse are :");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }
    }
}

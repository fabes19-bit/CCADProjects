using System;

namespace Assignment2_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Number of elements cannot be negative.");
                return;
            }

            int[] numbers = new int[n];
            int sum = 0;

            Console.WriteLine($"Input {n} elements in the array :");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"element - {i} : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }

            Console.WriteLine($"Sum of all elements stored in the array is : {sum}");
        }
    }
}

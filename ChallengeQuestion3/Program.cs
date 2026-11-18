using System;

namespace ChallengeQuestion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            Console.Write("Enter the desired width: ");
            if (!int.TryParse(Console.ReadLine(), out int width) || width <= 0)
            {
                Console.WriteLine("Invalid input. Width must be a positive integer.");
                return;
            }

            Console.WriteLine();

            for (int row = width; row >= 1; row--)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }
    }
}

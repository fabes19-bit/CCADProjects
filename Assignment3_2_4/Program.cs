using System;

namespace Assignment3_2_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine(" Assignment 3.2 - Question 4: Params Array & Out Parameters");
            Console.WriteLine("==========================================================\n");

            double n1 = ReadNumber("Enter the First number: ");
            double n2 = ReadNumber("Enter the Second number: ");
            double n3 = ReadNumber("Enter the third number: ");
            double n4 = ReadNumber("Enter the fourth number: ");

            // Calling function using params array and out parameters
            CalculateTotalAndAverage(out double total, out double average, n1, n2, n3, n4);

            Console.WriteLine($"\nThe average of {n1} , {n2} , {n3} , {n4} is: {average}");
            Console.WriteLine($"The total is {total}");
        }

        /// <summary>
        /// Calculates the total and average using a params array for arguments
        /// and out parameters to return both results to the caller.
        /// </summary>
        public static void CalculateTotalAndAverage(out double total, out double average, params double[] numbers)
        {
            total = 0;
            if (numbers == null || numbers.Length == 0)
            {
                average = 0;
                return;
            }

            foreach (double num in numbers)
            {
                total += num;
            }

            average = total / numbers.Length;
        }

        private static double ReadNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (double.TryParse(input?.Trim(), out double val))
                {
                    return val;
                }
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
            }
        }
    }
}

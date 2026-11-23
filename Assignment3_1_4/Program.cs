using System;

namespace Assignment3_1_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine(" Assignment 3.1 - Question 4: Replace Consecutive 1s with 0");
            Console.WriteLine("==========================================================\n");

            // Example from assignment prompt
            int[] example = { 0, 2, 1, 1, 9, 1, 1 };

            Console.WriteLine("--- Assignment Example ---");
            Console.WriteLine($"Input  : [{string.Join(",", example)}]");

            ReplaceFirstConsecutiveOnes(example);

            Console.WriteLine($"Output : [{string.Join(",", example)}]\n");

            // Interactive input
            Console.WriteLine("--- Interactive Test ---");
            Console.Write("Enter integers separated by commas or spaces (or press Enter to skip): ");
            string? input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                string[] parts = input.Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int[] userArray = Array.ConvertAll(parts, int.Parse);

                Console.WriteLine($"Input  : [{string.Join(",", userArray)}]");
                ReplaceFirstConsecutiveOnes(userArray);
                Console.WriteLine($"Output : [{string.Join(",", userArray)}]");
            }
        }

        /// <summary>
        /// Finds the first occurrence of 2 consecutive 1s in the array and changes their value to 0 in place.
        /// Stops at the first occurrence (using break).
        /// </summary>
        public static void ReplaceFirstConsecutiveOnes(int[] arr)
        {
            if (arr == null || arr.Length < 2)
            {
                return;
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 1 && arr[i + 1] == 1)
                {
                    arr[i] = 0;
                    arr[i + 1] = 0;
                    break; // Only the first occurrence
                }
            }
        }
    }
}

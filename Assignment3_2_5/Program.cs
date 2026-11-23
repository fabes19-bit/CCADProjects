using System;

namespace Assignment3_2_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("    Assignment 3.2 - Question 5: Array Linear Search      ");
            Console.WriteLine("==========================================================\n");

            // Verify the examples from the assignment
            Console.WriteLine("--- Assignment Examples ---");
            int[] ex1 = { 1, 5, 3 };
            Console.WriteLine($"Search([{string.Join(", ", ex1)}], 5) -> {Search(ex1, 5)}");

            int[] ex2 = { 9, 8, 3 };
            Console.WriteLine($"Search([{string.Join(", ", ex2)}], 3) -> {Search(ex2, 3)}");

            int[] ex3 = { 1, 2, 3 };
            Console.WriteLine($"Search([{string.Join(", ", ex3)}], 4) -> {Search(ex3, 4)}\n");

            // Interactive test
            Console.WriteLine("--- Interactive Test ---");
            Console.Write("Enter array elements separated by spaces or commas: ");
            string? arrayInput = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(arrayInput))
            {
                string[] parts = arrayInput.Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                var list = new System.Collections.Generic.List<int>();
                foreach (string part in parts)
                {
                    if (int.TryParse(part, out int val))
                    {
                        list.Add(val);
                    }
                }
                int[] userArray = list.ToArray();

                Console.Write("Enter item to search for: ");
                if (int.TryParse(Console.ReadLine(), out int target))
                {
                    int index = Search(userArray, target);
                    Console.WriteLine($"Search([{string.Join(", ", userArray)}], {target}) -> {index}");
                    if (index != -1)
                    {
                        Console.WriteLine($"Item {target} found at index {index}.");
                    }
                    else
                    {
                        Console.WriteLine($"Item {target} is not present in the array (-1).");
                    }
                }
            }
        }

        /// <summary>
        /// Finds the 0-based index of a given target item in an array using linear search.
        /// Returns -1 if the item is not present.
        /// </summary>
        public static int Search(int[] arr, int target)
        {
            if (arr == null)
            {
                return -1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

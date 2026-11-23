using System;

namespace Assignment3_1_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("   Assignment 3.1 - Question 3: Count Spaces in String    ");
            Console.WriteLine("==========================================================\n");

            Console.Write("Please input a string : ");
            string input = Console.ReadLine() ?? "";

            int count = CountSpaces(input);
            Console.WriteLine($"\"{input}\" contains {count} spaces");
        }

        /// <summary>
        /// Counts the number of whitespace space characters (' ') in the provided string.
        /// </summary>
        public static int CountSpaces(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int spaceCount = 0;
            foreach (char ch in str)
            {
                if (ch == ' ')
                {
                    spaceCount++;
                }
            }

            return spaceCount;
        }
    }
}

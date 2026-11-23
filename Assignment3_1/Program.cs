using System;
using System.Text;

namespace Assignment3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n==========================================================");
                Console.WriteLine("          20483 Programming in C# - Assignments 3.1       ");
                Console.WriteLine("==========================================================");
                Console.WriteLine("1. Question 1: Return Even Numbers (StringBuilder)");
                Console.WriteLine("2. Question 2: If Year is Leap");
                Console.WriteLine("3. Question 3: Count Spaces in String");
                Console.WriteLine("4. Question 4: Replace First Consecutive 1s with 0");
                Console.WriteLine("5. Run All 4 Questions Sequentially");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option (1-6): ");

                string choice = Console.ReadLine()?.Trim() ?? "";

                switch (choice)
                {
                    case "1":
                        RunQuestion1();
                        break;
                    case "2":
                        RunQuestion2();
                        break;
                    case "3":
                        RunQuestion3();
                        break;
                    case "4":
                        RunQuestion4();
                        break;
                    case "5":
                        RunQuestion1();
                        Console.WriteLine();
                        RunQuestion2();
                        Console.WriteLine();
                        RunQuestion3();
                        Console.WriteLine();
                        RunQuestion4();
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please enter 1-6.");
                        break;
                }
            }
        }

        /// <summary>
        /// Question 1: Write a method that returns a string of even numbers greater than 0 and less than 100.
        /// (Use StringBuilder class)
        /// </summary>
        static void RunQuestion1()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("  Question 1: Return Even Numbers (StringBuilder)");
            Console.WriteLine("----------------------------------------------------------");

            string evens = ReturnEvenNumbers();
            Console.WriteLine("ReturnEvenNumbers() ->");
            Console.WriteLine($"\"{evens}\"");
        }

        public static string ReturnEvenNumbers()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 2; i < 100; i += 2)
            {
                if (sb.Length > 0)
                {
                    sb.Append(' ');
                }
                sb.Append(i);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Question 2: Given a year as integer, write a method that checks if year is leap.
        /// Expected: IfYearIsLeap(2016) -> true, IfYearIsLeap(2018) -> false
        /// </summary>
        static void RunQuestion2()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("  Question 2: If Year is Leap");
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine($"IfYearIsLeap(2016) -> {IfYearIsLeap(2016)}");
            Console.WriteLine($"IfYearIsLeap(2018) -> {IfYearIsLeap(2018)}");
            Console.WriteLine($"IfYearIsLeap(2000) -> {IfYearIsLeap(2000)}");
            Console.WriteLine($"IfYearIsLeap(1900) -> {IfYearIsLeap(1900)}");

            Console.Write("\nEnter a custom year to test: ");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine($"IfYearIsLeap({year}) -> {IfYearIsLeap(year)}");
            }
        }

        public static bool IfYearIsLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        /// <summary>
        /// Question 3: Create a function to input a string and count number of spaces are in the string.
        /// </summary>
        static void RunQuestion3()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("  Question 3: Count Spaces in String");
            Console.WriteLine("----------------------------------------------------------");

            Console.Write("Please input a string : ");
            string input = Console.ReadLine() ?? "";

            int count = CountSpaces(input);
            Console.WriteLine($"\"{input}\" contains {count} spaces");
        }

        public static int CountSpaces(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int count = 0;
            foreach (char ch in str)
            {
                if (ch == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Question 4: Takes an array as input and finds the first occurrence of 2 consecutive 1s and changes their value to 0.
        /// For e.g: Input : [0,2,1,1,9,1,1] -> Output: [0,2,0,0,9,1,1]
        /// </summary>
        static void RunQuestion4()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("  Question 4: Replace First Consecutive 1s with 0");
            Console.WriteLine("----------------------------------------------------------");

            int[] sample = { 0, 2, 1, 1, 9, 1, 1 };
            Console.WriteLine($"Input  : [{string.Join(",", sample)}]");

            ReplaceFirstConsecutiveOnes(sample);
            Console.WriteLine($"Output : [{string.Join(",", sample)}]");
        }

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
                    break;
                }
            }
        }
    }
}

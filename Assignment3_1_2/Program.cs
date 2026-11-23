using System;

namespace Assignment3_1_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("       Assignment 3.1 - Question 2: Leap Year Check       ");
            Console.WriteLine("==========================================================\n");

            // Demonstration with expected test cases
            Console.WriteLine("--- Test Cases ---");
            Console.WriteLine($"IfYearIsLeap(2016) -> {IfYearIsLeap(2016)}");
            Console.WriteLine($"IfYearIsLeap(2018) -> {IfYearIsLeap(2018)}");
            Console.WriteLine($"IfYearIsLeap(2000) -> {IfYearIsLeap(2000)} (Century leap year)");
            Console.WriteLine($"IfYearIsLeap(1900) -> {IfYearIsLeap(1900)} (Century common year)\n");

            // Interactive input
            Console.Write("Enter a year to test: ");
            if (int.TryParse(Console.ReadLine(), out int inputYear))
            {
                bool isLeap = IfYearIsLeap(inputYear);
                Console.WriteLine($"IfYearIsLeap({inputYear}) -> {isLeap}");
            }
            else
            {
                Console.WriteLine("Invalid year format.");
            }
        }

        /// <summary>
        /// Checks whether a given year is a leap year according to the Gregorian calendar rules:
        /// 1. Divisible by 4, AND
        /// 2. Not divisible by 100, UNLESS also divisible by 400.
        /// </summary>
        public static bool IfYearIsLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}

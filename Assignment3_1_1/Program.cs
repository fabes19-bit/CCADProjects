using System;
using System.Text;

namespace Assignment3_1_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("   Assignment 3.1 - Question 1: Return Even Numbers       ");
            Console.WriteLine("==========================================================\n");

            string result = ReturnEvenNumbers();
            Console.WriteLine("ReturnEvenNumbers() ->");
            Console.WriteLine($"\"{result}\"");
        }

        /// <summary>
        /// Returns a string of even numbers greater than 0 and less than 100.
        /// Uses StringBuilder class as required.
        /// </summary>
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
    }
}

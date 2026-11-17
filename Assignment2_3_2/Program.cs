using System;

namespace Assignment2_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("       Assignment 2.3 - Question 2: Tip Calculator        ");
            Console.WriteLine("==========================================================");

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Write("\nEnter the bill total: ");
                decimal billTotal = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter the tip percentage (e.g., 15 for 15%): ");
                decimal tipPercentInput = Convert.ToDecimal(Console.ReadLine());

                // Convert percentage input to decimal rate for calculation and :P format specifier
                decimal tipRate = tipPercentInput / 100m;
                decimal tipAmount = billTotal * tipRate;
                decimal grandTotal = billTotal + tipAmount;

                // Display results using currency (:C) and percentage (:P) format specifiers
                Console.WriteLine("\n--- Receipt Summary ---");
                Console.WriteLine($"Bill Total:     {billTotal:C}");
                Console.WriteLine($"Tip Percentage: {tipRate:P}");
                Console.WriteLine($"Tip Amount:     {tipAmount:C}");
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Grand Total:    {grandTotal:C}");
                Console.WriteLine("-----------------------");

                Console.Write("\nCalculate another tip? (y/n): ");
                string? response = Console.ReadLine()?.Trim().ToLower();
                if (response != "y" && response != "yes")
                {
                    keepRunning = false;
                    Console.WriteLine("Exiting Tip Calculator. Goodbye!");
                }
            }
        }
    }
}

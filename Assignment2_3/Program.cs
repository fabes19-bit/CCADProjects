using System;
using System.IO;

namespace Assignment2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n==========================================================");
                Console.WriteLine("          10975 Programming - Assignments 2.3              ");
                Console.WriteLine("==========================================================");
                Console.WriteLine("1. Question 1: Save & Read Basic Details (Text File I/O)");
                Console.WriteLine("2. Question 2: Tip Calculator (Currency & % Specifiers)");
                Console.WriteLine("3. Run Both Assignments Sequentially");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");

                string choice = Console.ReadLine()?.Trim() ?? "";

                switch (choice)
                {
                    case "1":
                        RunFileIODemo();
                        break;
                    case "2":
                        RunTipCalculator();
                        break;
                    case "3":
                        RunFileIODemo();
                        Console.WriteLine();
                        RunTipCalculator();
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please enter 1, 2, 3, or 4.");
                        break;
                }
            }
        }

        /// <summary>
        /// Question 1: Create a text file, save dummy basic details (name, age, address),
        /// read the details back from the same file, and print them on the console.
        /// </summary>
        static void RunFileIODemo()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("  Question 1: Text File Write & Read");
            Console.WriteLine("----------------------------------------------------------");

            string filePath = Path.Combine(Environment.CurrentDirectory, "BasicDetails.txt");

            // Dummy data for basic details
            string name = "Jordan Avery";
            int age = 29;
            string address = "742 Evergreen Terrace, Springfield, IL 62704";

            try
            {
                Console.WriteLine($"Saving dummy details to: {filePath}");
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"Name:    {name}");
                    writer.WriteLine($"Age:     {age}");
                    writer.WriteLine($"Address: {address}");
                }
                Console.WriteLine("File created and saved successfully!\n");

                Console.WriteLine("--- Reading Details Back From File ---");
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                Console.WriteLine("--------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error handling file: {ex.Message}");
            }
        }

        /// <summary>
        /// Question 2: Tip Calculator taking bill total and tip %, displaying grand total
        /// using currency (:C) and percentage (:P) format specifiers.
        /// </summary>
        static void RunTipCalculator()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("  Question 2: Tip Calculator");
            Console.WriteLine("----------------------------------------------------------");

            Console.Write("Enter the bill total: ");
            decimal billTotal = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the tip percentage (e.g., 15 for 15%): ");
            decimal tipPercentInput = Convert.ToDecimal(Console.ReadLine());

            decimal tipRate = tipPercentInput / 100m;
            decimal tipAmount = billTotal * tipRate;
            decimal grandTotal = billTotal + tipAmount;

            Console.WriteLine("\n--- Receipt Summary ---");
            Console.WriteLine($"Bill Total:     {billTotal:C}");
            Console.WriteLine($"Tip Percentage: {tipRate:P}");
            Console.WriteLine($"Tip Amount:     {tipAmount:C}");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Grand Total:    {grandTotal:C}");
            Console.WriteLine("-----------------------");
        }
    }
}

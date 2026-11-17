using System;
using System.IO;

namespace Assignment2_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================================================");
            Console.WriteLine("   Assignment 2.3 - Question 1: File Write & Read Demo    ");
            Console.WriteLine("==========================================================\n");

            // Define file path in the application directory
            string filePath = Path.Combine(Environment.CurrentDirectory, "BasicDetails.txt");

            // Dummy data for basic details
            string name = "Jordan Avery";
            int age = 29;
            string address = "742 Evergreen Terrace, Springfield, IL 62704";

            try
            {
                // 1. Create a text file and save basic details
                Console.WriteLine($"Creating and writing details to: {filePath}");
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine($"Name:    {name}");
                    writer.WriteLine($"Age:     {age}");
                    writer.WriteLine($"Address: {address}");
                }
                Console.WriteLine("Details successfully saved to file!\n");

                // 2. Read the details from the same file and print on console
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
                Console.WriteLine($"An error occurred while accessing the file: {ex.Message}");
            }
        }
    }
}

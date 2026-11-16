using System;

namespace Assignment1_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("    Assignment 1.4 - Question 2: Student Class    ");
            Console.WriteLine("==================================================");

            bool keepRunning = true;

            while (keepRunning)
            {
                // Instantiate the class
                Student student = new Student();

                Console.WriteLine("\nPlease enter the student information:");

                // Input StudentId
                Console.Write("Enter Student ID (int): ");
                student.StudentId = Convert.ToInt32(Console.ReadLine());

                // Input StudentFname
                Console.Write("Enter First Name (string): ");
                student.StudentFname = Console.ReadLine() ?? "";

                // Input StudentLname
                Console.Write("Enter Last Name (string): ");
                student.StudentLname = Console.ReadLine() ?? "";

                // Input StudentGrade
                Console.Write("Enter Student Grade (char, e.g. A, B, C): ");
                string? gradeInput = Console.ReadLine();
                student.StudentGrade = !string.IsNullOrEmpty(gradeInput) ? gradeInput[0] : 'N';

                // Display the data back on console
                Console.WriteLine("\n--------------------------------------------------");
                Console.WriteLine("Displaying Student Data via Public Properties:");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"Student ID:   {student.StudentId}");
                Console.WriteLine($"First Name:   {student.StudentFname}");
                Console.WriteLine($"Last Name:    {student.StudentLname}");
                Console.WriteLine($"Grade:        {student.StudentGrade}");
                Console.WriteLine("--------------------------------------------------");

                Console.Write("\nWould you like to enter another student? (y/n): ");
                string? response = Console.ReadLine()?.Trim().ToLower();
                if (response != "y" && response != "yes")
                {
                    keepRunning = false;
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}

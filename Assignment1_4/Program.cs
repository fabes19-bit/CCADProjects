using System;

namespace Assignment1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n==================================================");
                Console.WriteLine("          10975 Programming - Assignments 1.4      ");
                Console.WriteLine("==================================================");
                Console.WriteLine("1. Question 1: Point Structure (Compare P1 & P2)");
                Console.WriteLine("2. Question 2: Student Class (Properties & Display)");
                Console.WriteLine("3. Run Both Assignments Sequentially");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");

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
                        RunQuestion1();
                        Console.WriteLine();
                        RunQuestion2();
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
        /// Question 1: Create a structure named "Point" and 2 data members: X and Y coordinate.
        /// Declare 2 points: P1 and P2. Determine if P2 is to the right or left of P1 or on same axis,
        /// by comparing the x coordinates. (if p1.x is more than p2.x, it is to the right)
        /// </summary>
        static void RunQuestion1()
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("  Question 1: Point Structure Comparison");
            Console.WriteLine("--------------------------------------------------");

            Point P1 = new Point();
            Point P2 = new Point();

            Console.WriteLine("Enter coordinates for Point P1:");
            Console.Write("  Enter P1.X: ");
            P1.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("  Enter P1.Y: ");
            P1.Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter coordinates for Point P2:");
            Console.Write("  Enter P2.X: ");
            P2.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("  Enter P2.Y: ");
            P2.Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n--- Results ---");
            Console.WriteLine($"Point P1: {P1}");
            Console.WriteLine($"Point P2: {P2}");

            // Determine if P2 is to the right or left of P1 or on same axis
            if (P2.X > P1.X)
            {
                Console.WriteLine($"-> P2 is to the RIGHT of P1 (P2.X [{P2.X}] > P1.X [{P1.X}]).");
            }
            else if (P2.X < P1.X)
            {
                Console.WriteLine($"-> P2 is to the LEFT of P1 (P1 is to the right of P2, since P1.X [{P1.X}] > P2.X [{P2.X}]).");
            }
            else
            {
                Console.WriteLine($"-> Points P1 and P2 are on the SAME AXIS (P1.X == P2.X == {P1.X}).");
            }
        }

        /// <summary>
        /// Question 2: Write a class: "Student" with private data members:
        /// StudentId (int), StudentFname (string), StudentLname (string), StudentGrade (char)
        /// and public properties for each data member. Instantiate the class and assign data to properties.
        /// Display the data back on console.
        /// </summary>
        static void RunQuestion2()
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("  Question 2: Student Class & Public Properties");
            Console.WriteLine("--------------------------------------------------");

            // Instantiate the class
            Student student = new Student();

            Console.WriteLine("Enter student details:");
            Console.Write("  Enter Student ID (int): ");
            student.StudentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("  Enter First Name (string): ");
            student.StudentFname = Console.ReadLine() ?? "";

            Console.Write("  Enter Last Name (string): ");
            student.StudentLname = Console.ReadLine() ?? "";

            Console.Write("  Enter Grade (char): ");
            string? gradeInput = Console.ReadLine();
            student.StudentGrade = !string.IsNullOrEmpty(gradeInput) ? gradeInput[0] : 'N';

            // Display the data back on console
            Console.WriteLine("\n--- Displaying Student Data via Public Properties ---");
            Console.WriteLine($"Student ID:   {student.StudentId}");
            Console.WriteLine($"First Name:   {student.StudentFname}");
            Console.WriteLine($"Last Name:    {student.StudentLname}");
            Console.WriteLine($"Grade:        {student.StudentGrade}");
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}

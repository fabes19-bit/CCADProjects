using System;
using System.Collections.Generic;

namespace Assignment3_2
{
    internal class Program
    {
        private static readonly Queue<int> tokenQueue = new Queue<int>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n==========================================================");
                Console.WriteLine("          20483 Programming in C# - Assignments 3.2       ");
                Console.WriteLine("==========================================================");
                Console.WriteLine("1. Question 1: 2D Array Matrix Display");
                Console.WriteLine("2. Question 2: Addition of Two Matrices");
                Console.WriteLine("3. Question 3: Circle Operator Overloading (+ and -)");
                Console.WriteLine("4. Question 4: Params Array & Out Parameters (Total & Average)");
                Console.WriteLine("5. Question 5: Array Linear Search");
                Console.WriteLine("6. Run All 5 Questions Sequentially");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option (1-7): ");

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
                        RunQuestion5();
                        break;
                    case "6":
                        RunQuestion1();
                        Console.WriteLine();
                        RunQuestion2();
                        Console.WriteLine();
                        RunQuestion3();
                        Console.WriteLine();
                        RunQuestion4();
                        Console.WriteLine();
                        RunQuestion5();
                        break;
                    case "7":
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please enter 1-7.");
                        break;
                }
            }
        }

        // ====================================================================
        // Question 1: 2D Array Matrix Display
        // ====================================================================
        static void RunQuestion1()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("  Question 1: 2D Array Matrix Display");
            Console.WriteLine("----------------------------------------------------------");

            int[,] sample = {
                { 2, 3, 4 },
                { 1, 4, 6 }
            };

            Console.WriteLine("Assignment Sample Matrix:");
            PrintFormattedMatrix(sample);

            Console.Write("\nWould you like to input a custom matrix? (y/n): ");
            string response = Console.ReadLine()?.Trim().ToLower() ?? "";

            if (response == "y" || response == "yes")
            {
                int rows = ReadPositiveInt("Enter number of rows: ");
                int cols = ReadPositiveInt("Enter number of columns: ");

                int[,] custom = new int[rows, cols];

                Console.WriteLine($"\nEnter elements for a {rows}x{cols} matrix (one-by-one or separated by spaces):");
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        custom[r, c] = ReadElement($"Element [{r},{c}]: ");
                    }
                }

                Console.WriteLine("\nCustom Matrix:");
                PrintFormattedMatrix(custom);
            }
        }

        public static void PrintFormattedMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                Console.Write("|");
                for (int c = 0; c < cols; c++)
                {
                    Console.Write($" {matrix[r, c]} |");
                }
                Console.WriteLine();
            }
        }

        // ====================================================================
        // Question 2: Addition of Two Matrices
        // ====================================================================
        static void RunQuestion2()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("  Question 2: Addition of Two Matrices");
            Console.WriteLine("----------------------------------------------------------");

            int size = ReadMatrixSize("Input the size of the square matrix (less than 5): ");

            int[,] first = new int[size, size];
            int[,] second = new int[size, size];
            int[,] sum = new int[size, size];

            Console.WriteLine("\nInput elements in the first matrix :");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    first[i, j] = ReadElement($"element - [{i}],[{j}] : ");
                }
            }

            Console.WriteLine("\nInput elements in the second matrix :");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    second[i, j] = ReadElement($"element - [{i}],[{j}] : ");
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sum[i, j] = first[i, j] + second[i, j];
                }
            }

            Console.WriteLine("\nThe First matrix is:");
            PrintSimpleMatrix(first);

            Console.WriteLine("\nThe Second matrix is :");
            PrintSimpleMatrix(second);

            Console.WriteLine("\nThe Addition of two matrix is :");
            PrintSimpleMatrix(sum);
        }

        public static void PrintSimpleMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // ====================================================================
        // Question 3: Circle Operator Overloading
        // ====================================================================
        static void RunQuestion3()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("  Question 3: Circle Operator Overloading (+ and -)");
            Console.WriteLine("----------------------------------------------------------");

            double r1 = ReadPositiveDouble("Enter radius for Circle 1: ");
            double r2 = ReadPositiveDouble("Enter radius for Circle 2: ");

            Circle c1 = new Circle(r1);
            Circle c2 = new Circle(r2);

            Console.WriteLine("\nCircle 1: Radius = {0:F2}, Area = {1:F2}", c1.Radius, c1.Area);
            Console.WriteLine("Circle 2: Radius = {0:F2}, Area = {1:F2}", c2.Radius, c2.Area);

            double sumArea = c1 + c2;
            double diffArea = c1 - c2;

            Console.WriteLine("\n--- Results ---");
            Console.WriteLine($"c1 + c2 (Sum of Areas)        = {sumArea:F2}");
            Console.WriteLine($"c1 - c2 (Difference of Areas) = {diffArea:F2}");
        }

        // ====================================================================
        // Question 4: Params Array and Out Parameters
        // ====================================================================
        static void RunQuestion4()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("  Question 4: Params Array & Out Parameters");
            Console.WriteLine("----------------------------------------------------------");

            double n1 = ReadAnyDouble("Enter the First number: ");
            double n2 = ReadAnyDouble("Enter the Second number: ");
            double n3 = ReadAnyDouble("Enter the third number: ");
            double n4 = ReadAnyDouble("Enter the fourth number: ");

            CalculateTotalAndAverage(out double total, out double avg, n1, n2, n3, n4);

            Console.WriteLine($"\nThe average of {n1} , {n2} , {n3} , {n4} is: {avg}");
            Console.WriteLine($"The total is {total}");
        }

        public static void CalculateTotalAndAverage(out double total, out double average, params double[] numbers)
        {
            total = 0;
            if (numbers == null || numbers.Length == 0)
            {
                average = 0;
                return;
            }

            foreach (double n in numbers)
            {
                total += n;
            }
            average = total / numbers.Length;
        }

        // ====================================================================
        // Question 5: Array Linear Search
        // ====================================================================
        static void RunQuestion5()
        {
            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("  Question 5: Array Linear Search");
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("Examples from Assignment:");
            Console.WriteLine($"Search([1, 5, 3], 5) -> {Search(new int[] { 1, 5, 3 }, 5)}");
            Console.WriteLine($"Search([9, 8, 3], 3) -> {Search(new int[] { 9, 8, 3 }, 3)}");
            Console.WriteLine($"Search([1, 2, 3], 4) -> {Search(new int[] { 1, 2, 3 }, 4)}");

            Console.Write("\nWould you like to search a custom array? (y/n): ");
            string resp = Console.ReadLine()?.Trim().ToLower() ?? "";
            if (resp == "y" || resp == "yes")
            {
                Console.Write("Enter array elements separated by spaces or commas: ");
                string? input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    string[] parts = input.Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
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
                        int idx = Search(userArray, target);
                        Console.WriteLine($"Search([{string.Join(", ", userArray)}], {target}) -> {idx}");
                    }
                }
            }
        }

        public static int Search(int[] arr, int target)
        {
            if (arr == null) return -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target) return i;
            }
            return -1;
        }

        // ====================================================================
        // Input Helpers
        // ====================================================================
        private static int ReadMatrixSize(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (int.TryParse(input?.Trim(), out int val) && val > 0 && val < 5) return val;
                Console.WriteLine("Invalid size. Please enter a positive integer less than 5.\n");
            }
        }

        private static int ReadPositiveInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (int.TryParse(input?.Trim(), out int val) && val > 0) return val;
                Console.WriteLine("Please enter a valid positive integer.\n");
            }
        }

        private static double ReadPositiveDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (double.TryParse(input?.Trim(), out double val) && val >= 0) return val;
                Console.WriteLine("Please enter a non-negative number.\n");
            }
        }

        private static double ReadAnyDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (double.TryParse(input?.Trim(), out double val)) return val;
                Console.WriteLine("Please enter a valid number.\n");
            }
        }

        private static int ReadElement(string prompt)
        {
            while (tokenQueue.Count == 0)
            {
                Console.Write(prompt);
                string? line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(new[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string part in parts)
                {
                    if (int.TryParse(part, out int val))
                    {
                        tokenQueue.Enqueue(val);
                    }
                }
            }

            return tokenQueue.Dequeue();
        }
    }
}

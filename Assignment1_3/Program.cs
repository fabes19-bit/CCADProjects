namespace Assignment1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Simple Calculator Menu ---");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option (1-5): ");

                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Exiting program. Goodbye!");
                    break;
                }

                if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
                {
                    Console.WriteLine("Invalid option. Please choose between 1 and 5.");
                    continue;
                }

                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                {
                    case "1":
                        Add(num1, num2);
                        break;
                    case "2":
                        Subtract(num1, num2);
                        break;
                    case "3":
                        Multiply(num1, num2);
                        break;
                    case "4":
                        Divide(num1, num2);
                        break;
                }

                Console.Write("\nDo you want to continue? (y/n): ");
                string response = Console.ReadLine().Trim().ToLower();
                if (response != "y" && response != "yes")
                {
                    running = false;
                    Console.WriteLine("Exiting program. Goodbye!");
                }
            }
        }

        static void Add(double a, double b) => Console.WriteLine($"Result: {a} + {b} = {a + b}");
        static void Subtract(double a, double b) => Console.WriteLine($"Result: {a} - {b} = {a - b}");
        static void Multiply(double a, double b) => Console.WriteLine($"Result: {a} * {b} = {a * b}");
        static void Divide(double a, double b)
        {
            if (b == 0)
                Console.WriteLine("Error: Cannot divide by zero.");
            else
                Console.WriteLine($"Result: {a} / {b} = {a / b}");
        }
    }
}

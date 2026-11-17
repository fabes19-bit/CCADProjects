using System;

namespace ChallengeQuestion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            string? input = Console.ReadLine();

            if (!double.TryParse(input, out double temp))
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric temperature.");
                return;
            }

            if (temp <= 10)
            {
                Console.WriteLine("Freezing weather.");
            }
            else if (temp <= 20)
            {
                Console.WriteLine("Very Cold weather.");
            }
            else if (temp <= 35)
            {
                Console.WriteLine("Cold weather.");
            }
            else if (temp <= 50)
            {
                Console.WriteLine("Normal in Weather.");
            }
            else if (temp <= 65)
            {
                Console.WriteLine("Its Hot.");
            }
            else if (temp <= 80)
            {
                Console.WriteLine("Its very hot.");
            }
            else
            {
                Console.WriteLine("Its extremely hot (above 80°F).");
            }
        }
    }
}

using System;

namespace ChallengeQuestion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string validUserId = "admin";
            const string validPassword = "password123";
            const int maxAttempts = 3;

            int attempts = 0;
            bool isAuthenticated = false;

            Console.WriteLine("==================================================");
            Console.WriteLine("       Challenge Question 2: User Login           ");
            Console.WriteLine("==================================================");
            Console.WriteLine($"(Demo credentials -> User ID: {validUserId} | Password: {validPassword})\n");

            while (attempts < maxAttempts)
            {
                Console.Write("Enter User ID: ");
                string userId = Console.ReadLine() ?? "";

                Console.Write("Enter Password: ");
                string password = Console.ReadLine() ?? "";

                if (userId == validUserId && password == validPassword)
                {
                    isAuthenticated = true;
                    break;
                }

                attempts++;
                int remaining = maxAttempts - attempts;

                if (remaining > 0)
                {
                    Console.WriteLine($"Invalid User ID or Password. Attempts remaining: {remaining}\n");
                }
            }

            if (isAuthenticated)
            {
                Console.WriteLine("\nLogin successful! Welcome.");
            }
            else
            {
                Console.WriteLine("\nAccess denied: You have been rejected after 3 wrong attempts.");
            }
        }
    }
}

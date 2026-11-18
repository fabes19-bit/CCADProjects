using System;

namespace Assignment2_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the value for X coordinate : ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input the value for Y coordinate : ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies at the Origin.");
            }
            else if (x == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the Y-axis.");
            }
            else
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the X-axis.");
            }
        }
    }
}

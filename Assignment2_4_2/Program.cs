using System;

namespace Assignment2_4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the 1st number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input the 2nd number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input the 3rd number : ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("All three numbers are equal.");
            }
            else if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("The 1st Number is the greatest among three");
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("The 2nd Number is the greatest among three");
            }
            else
            {
                Console.WriteLine("The 3rd Number is the greatest among three");
            }
        }
    }
}

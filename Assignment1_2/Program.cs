namespace Assignment1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("The first 10 natural number is :");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine($"The Sum is : {sum}");
        }
    }
}

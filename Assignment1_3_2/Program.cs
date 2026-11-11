namespace Assignment1_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Different ways to declare and initialize an array
            // Way A: Declare size first, then assign values by index (starts at 0)
            int[] arrayA = new int[3];
            arrayA[0] = 10;
            arrayA[1] = 20;
            arrayA[2] = 30;

            // Way B: Declare and initialize with values immediately
            int[] arrayB = new int[] { 50, 10, 40, 20, 30 };

            // Way C: Shorthand initialization (compiler counts elements automatically)
            string[] arrayC = { "C#", "Cloud", "Security" };

            Console.WriteLine("--- Array Declarations ---");
            Console.WriteLine("arrayA: " + string.Join(", ", arrayA));
            Console.WriteLine("arrayB: " + string.Join(", ", arrayB));
            Console.WriteLine("arrayC: " + string.Join(", ", arrayC));

            // 2. Array Class Properties
            Console.WriteLine("\n--- Array Properties ---");
            Console.WriteLine($"Length of arrayB (total items): {arrayB.Length}");
            Console.WriteLine($"Rank of arrayB (number of dimensions): {arrayB.Rank}");

            // 3. Array Class Methods
            Console.WriteLine("\n--- Array Methods ---");

            Array.Sort(arrayB);
            Console.WriteLine("arrayB after Array.Sort(): " + string.Join(", ", arrayB));

            Array.Reverse(arrayB);
            Console.WriteLine("arrayB after Array.Reverse(): " + string.Join(", ", arrayB));

            int position = Array.IndexOf(arrayB, 40);
            Console.WriteLine($"Index position of '40' using Array.IndexOf(): {position}");

            Array.Clear(arrayB, 0, 2);
            Console.WriteLine("arrayB after Array.Clear() on first 2 spots: " + string.Join(", ", arrayB));
        }
    }
}

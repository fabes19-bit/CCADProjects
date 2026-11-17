namespace Assignment2_1_2
{
    /// <summary>
    /// Maths class providing overloaded static methods for addition and multiplication.
    /// Named 'Maths' to avoid naming conflicts with System.Math.
    /// All methods are public and static as required.
    /// </summary>
    public static class Maths
    {
        /// <summary>
        /// a. Add two integers.
        /// </summary>
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// b. Add three decimal numbers.
        /// </summary>
        public static decimal Add(decimal num1, decimal num2, decimal num3)
        {
            return num1 + num2 + num3;
        }

        /// <summary>
        /// c. Multiply two single-precision floating-point numbers.
        /// </summary>
        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// d. Multiply three single-precision floating-point numbers.
        /// </summary>
        public static float Multiply(float num1, float num2, float num3)
        {
            return num1 * num2 * num3;
        }
    }
}

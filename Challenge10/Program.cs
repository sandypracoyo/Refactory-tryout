using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create methods called Sum, Substract, Multiply, Divide
            // Each methods should accept two parameters number
            // and also return a number.
            // Example:
            // Sum(1, 6) // Output: 7
            Console.WriteLine(Sum(1, 6));
            Console.WriteLine(Substract(6, 1));
            Console.WriteLine(Multiply(1, 6));
            Console.WriteLine(Divide(6, 3));

        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}

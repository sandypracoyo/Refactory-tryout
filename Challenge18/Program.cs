using System;
using System.Linq; //menggunakan system linq untuk menggunakan fungsi max,min,average

namespace FindMinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54 };

            FindMax(numbers); // Output: 330
            FindMin(numbers); // Output: -65
            FindAverage(numbers); // Output: 52.16
        }

        static int FindMax(int[] numbers)
        {
            Console.WriteLine(numbers.Max());
            return 0;
        }

        static int FindMin(int[] numbers)
        {
            Console.WriteLine(numbers.Min());
            return 0;
        }

        static int FindAverage(int[] numbers)
        {
            Console.WriteLine(numbers.Average());
            return 0;
        }
    }
}

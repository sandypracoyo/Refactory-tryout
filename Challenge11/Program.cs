using System;

namespace SumArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sum all args
            // You can run "dotnet run -- 1 5 8 3"
            // The output should be 17
            int Sum;
            int a = int.Parse(args[0]);
            int b = int.Parse(args[1]);
            int c = int.Parse(args[2]);
            int d = int.Parse(args[3]);

            Sum = a + b + c + d;
            Console.WriteLine(Sum);



        }
    }
}

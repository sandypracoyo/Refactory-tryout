using System;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method called Grade()
            // That method should accept an integer with some criteria
            // 1) If the input more than 90 the output will be "A"
            // 2) If the input within range 80 to 89 the output will be "B"
            // 3) If the input within range 70 to 79 the output will be "C"
            // 4) If the input within range 60 to 69 the output will be "D"
            // 5) If the input below 59 the output will be "E"
            Grade();
        }

        static void Grade()
        {
            int angka;
            Console.WriteLine("Masukkan nilai :");
            angka = int.Parse(Console.ReadLine());

            if (angka > 90)
            {
                Console.WriteLine("A");
            }
            else if (angka >= 80)
            {
                Console.WriteLine("B");
            }
            else if (angka >= 70)
            {
                Console.WriteLine("C");
            }
            else if (angka >= 60)
            {
                Console.WriteLine("D");
            }
            else if (angka <= 59)
            {
                Console.WriteLine("E");
            }
        }
    }
}

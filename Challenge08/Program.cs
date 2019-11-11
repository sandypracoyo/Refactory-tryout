using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method called IsLeapYear().
            // That method should accept a year as input.
            // The output should be a boolean.
            Console.WriteLine("Masukkan Tahun : ");
            int tahun = int.Parse(Console.ReadLine());
            bool hasil = IsLeapYear(tahun);
            Console.WriteLine(hasil);

        }
        public static bool IsLeapYear(int tahun)
        {
            bool param;
            if ((tahun % 4 == 0 && tahun % 100 != 0) || (tahun % 400 == 0))
            {
                param = true;
            }
            else
            {
                param = false;
            }
            return param;
        }

    }
}

using System;

namespace DaysToNextBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            // Count the days of your next birthday
            DateTime mybday = DateTime.Parse("09/01/2020");
            DateTime today = DateTime.Parse(DateTime.Now.ToString());
            int ulangTahun = (mybday - today).Days;
            Console.WriteLine($"{ulangTahun} days remaining to my next birthday.");
        }
    }
}

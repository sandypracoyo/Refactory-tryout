using System;

namespace ToUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a progam that be able to
            // transform all string into uppercase.

            string kata;
            string hasil;
            Console.WriteLine("Masukkan kata : ");
            kata = Console.ReadLine();
            hasil = kata.ToUpper();
            Console.WriteLine("Kata yang di masukkan : " + kata);
            Console.WriteLine("Hasil uppercase: " + hasil);

        }
    }
}

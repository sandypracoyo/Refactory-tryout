﻿using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new method with ability to detect odd or even number.
            // Example:
            // IsOdd(4) // false
            // IsEven(8) // true

            int angka;
            Console.WriteLine("Masukkan angka :");
            angka = int.Parse(Console.ReadLine());

            if (angka % 2 == 0)
            {
                Console.WriteLine($"Angka {angka} adalah bilangan genap");
            }
            else
            {
                Console.WriteLine($"Angka {angka} adalah bilangan ganjil");
            }
        }
    }
}

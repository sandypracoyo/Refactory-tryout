using System;

namespace TempratureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program to convert temprature unit
            CelciusToFahrenheit(0); // Output: 32
            FahrenheitToCelcius(50); // Output: 10
            CelciusToKelvin(100); // Output: 373.15
            KelvinToCelcius(375); // Output: 101.85
            KelvinToFahrenheit(375); // Output: 215.33
            FahrenheitToKelvin(12); // Output: 262.039
        }

        private static double CelciusToFahrenheit(double value)
        {
            double fahrenheit;
            double celcius = value;
            fahrenheit = (celcius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit : " + fahrenheit);
            return 0;
        }

        private static double FahrenheitToCelcius(double value)
        {
            double celcius;
            double fahrenheit = value;
            celcius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celcius : " + celcius);
            return 0;
        }

        private static double CelciusToKelvin(double value)
        {
            double kelvin;
            double celcius = value;
            kelvin = celcius + 273.15;
            Console.WriteLine("Kelvin : " + kelvin);
            return 0;
        }

        private static double KelvinToCelcius(double value)
        {
            double celcius;
            double kelvin = value;
            celcius = kelvin - 273.15;
            Console.WriteLine("Celcius : " + celcius);
            return 0;
        }

        private static double KelvinToFahrenheit(double value)
        {
            double fahrenheit;
            double kelvin = value;
            fahrenheit = (kelvin - 273.15) * 9 / 5 + 32;
            Console.WriteLine("Fahrenheit : " + fahrenheit);
            return 0;
        }

        private static double FahrenheitToKelvin(double value)
        {
            double kelvin;
            double fahrenheit = value;
            kelvin = (fahrenheit - 32) * 5 / 9 + 273.15;
            Console.WriteLine("Kelvin : " + kelvin);
            return 0;
        }
    }
}

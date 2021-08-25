using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int originalFahrenheit;
            int celsius;
            int calculatedFahrenheit;

            // calculate and display for 0 degrees
            originalFahrenheit = 0;
            Console.WriteLine("Original Fahrenheit: " + originalFahrenheit);
            celsius = (originalFahrenheit - 32) / 9 * 5;
            Console.WriteLine("Calculated Celsius: " + celsius);
            calculatedFahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Calculated Fahrenheit: " + calculatedFahrenheit);

            // calculate and display for 32 degrees
            originalFahrenheit = 32;
            Console.WriteLine("Original Fahrenheit: " + originalFahrenheit);
            celsius = (originalFahrenheit - 32) / 9 * 5;
            Console.WriteLine("Calculated Celsius: " + celsius);
            calculatedFahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Calculated Fahrenheit: " + calculatedFahrenheit);

            // calculate and display for 212 degrees
            originalFahrenheit = 212;
            Console.WriteLine("Original Fahrenheit: " + originalFahrenheit);
            celsius = (originalFahrenheit - 32) / 9 * 5;
            Console.WriteLine("Calculated Celsius: " + celsius);
            calculatedFahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Calculated Fahrenheit: " + calculatedFahrenheit);

            // declare float variables
            float floatOriginalFahrenheit;
            float floatCelsius;
            float floatCalculatedFahrenheit;

            // calculate and display for 0 degrees using float
            floatOriginalFahrenheit = 0;
            Console.WriteLine("Float Original Fahrenheit: " + floatOriginalFahrenheit);
            floatCelsius = (floatOriginalFahrenheit - 32) / 9 * 5;
            Console.WriteLine("Float Calculated Celsius: " + floatCelsius);
            floatCalculatedFahrenheit = (floatCelsius * 9) / 5 + 32;
            Console.WriteLine("Float Calculated Fahrenheit: " + floatCalculatedFahrenheit);

            // declare double variables
            double doubleOriginalFahrenheit;
            double doubleCelsius;
            double doubleCalculatedFahrenheit;

            // calculate and display for 0 degrees using double
            doubleOriginalFahrenheit = 0;
            Console.WriteLine("Double Original Fahrenheit: " + doubleOriginalFahrenheit);
            doubleCelsius = (doubleOriginalFahrenheit - 32) / 9 * 5;
            Console.WriteLine("Double Calculated Celsius: " + doubleCelsius);
            doubleCalculatedFahrenheit = (doubleCelsius * 9) / 5 + 32;
            Console.WriteLine("Double Calculated Fahrenheit: " + doubleCalculatedFahrenheit);
        }
    }
}

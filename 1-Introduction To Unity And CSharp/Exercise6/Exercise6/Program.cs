using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an degree: ");
            float degrees = float.Parse(Console.ReadLine());
            float radians = degrees * ((float)Math.PI / 180);
            Console.WriteLine("Cosine: " + Math.Cos(radians));
            Console.WriteLine("Sine:   " + Math.Sin(radians));

        }
    }
}

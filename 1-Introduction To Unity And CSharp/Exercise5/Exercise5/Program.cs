using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MaxScore = 100;
            int score = 55;
            float percent = (float)score / MaxScore;
            Console.WriteLine(percent);
        }
    }
}

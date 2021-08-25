using System;

namespace Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("∗∗∗∗∗∗∗∗∗∗∗∗∗∗\n");
            Console.WriteLine("MENU : \n");
            Console.WriteLine("1-NewGame\n");
            Console.WriteLine("2-LoadGame\n");
            Console.WriteLine("3-Options\n");
            Console.WriteLine("4-Quit\n");
            Console.WriteLine("∗∗∗∗∗∗∗∗∗∗∗∗∗∗\n");

            int theCase = int.Parse(Console.ReadLine());
            switch (theCase)
            {
                case 1:
                    Console.WriteLine("Welcome to new game");
                    return;
                case 2:
                    Console.WriteLine("Choose a save to load");
                    return;
                case 3:
                    Console.WriteLine("Options");
                    return;
                case 4:
                    Console.WriteLine("Good Bye!");
                    return;
                default:
                    Console.WriteLine("Choose one of them");
                    return;

            }
        }
    }
}

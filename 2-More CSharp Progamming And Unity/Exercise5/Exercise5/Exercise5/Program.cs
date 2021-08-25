using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("∗∗∗∗∗∗∗∗∗∗∗∗∗∗\n");
            Console.WriteLine("MENU: \n");
            Console.WriteLine("1-NewGame \n");
            Console.WriteLine("2-LoadGame\n");
            Console.WriteLine("3-Options\n");
            Console.WriteLine("4-Quit\n");
            Console.WriteLine("∗∗∗∗∗∗∗∗∗∗∗∗∗∗\n");
            choice = int.Parse(Console.ReadLine());

            while (choice != 4) 
            {
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Creating new game...\n");
                        break;
                    case 2:
                        Console.WriteLine("Loading game...\n");
                        break;
                    case 3:
                        Console.WriteLine("Loading options...\n");
                        break;
                    case 4:
                        Console.WriteLine("Goodbye\n");
                        Console.ReadLine();
                        break;
                }
            }

        }
    }
}

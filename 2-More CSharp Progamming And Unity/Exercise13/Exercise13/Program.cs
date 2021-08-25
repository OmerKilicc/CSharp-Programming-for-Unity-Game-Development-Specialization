using System;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            string birthMonth;
            int birthDay;

            string reminderMonth;
            int reminderDay;

            Console.WriteLine("Please enter your birth month!");
            birthMonth = Console.ReadLine();

            Console.WriteLine("Please enter your birth day!");
            birthDay = int.Parse(Console.ReadLine());

            if(birthDay != 1)
            {
                reminderMonth = birthMonth;
                reminderDay = birthDay - 1;
            }
            else
            {
                if(birthMonth == "January")
                {
                    reminderMonth = "December";
                    reminderDay = 31;
                }
                else if
            }

        }
    }
}

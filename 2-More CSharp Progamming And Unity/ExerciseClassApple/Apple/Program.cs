using System;
using System.Diagnostics;

namespace Apple
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(true,5);
            

            float num = apple.AmountLeft;
            bool organic = apple.Organic;

            while (apple.AmountLeft >= 0)
            {
                apple.TakeBite(0.5f);
                Console.WriteLine(apple.AmountLeft);
            }
            

        }
    }

    public class Apple
    {
        float amountLeft = 5;
        bool organic = false;

        public float AmountLeft
        {
            get { return amountLeft; }
        }

        public bool Organic
        {
            get { return organic; }
        }

        public void TakeBite(float size)
        {
            amountLeft -= size;
        }

        public Apple(bool organic,float amountLeft)
        {
            this.organic = organic;
            this.amountLeft = amountLeft;
        }
    }
}

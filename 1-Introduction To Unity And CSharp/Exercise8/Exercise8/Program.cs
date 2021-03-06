using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    /// <summary>
    /// Exercise 8 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates rolling and using two dice
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            int sum;
            // initialize random number generator
            RandomNumberGenerator.Initialize();

            // create two dice
            Die die1 = new Die();
            Die die2 = new Die();

            die1.Roll();
            die2.Roll();

            sum = die1.TopSide + die2.TopSide;
            Console.WriteLine(die1.TopSide + " " + die2.TopSide + " " + sum);
            
                
            // tell the dice to roll themselves

            // print the top sides and the sum of the dice

            Console.WriteLine();
        }
    }
}

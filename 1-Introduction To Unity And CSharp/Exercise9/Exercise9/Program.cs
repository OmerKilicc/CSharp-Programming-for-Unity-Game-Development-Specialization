using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{    
    /// <summary>
    /// Exercise 9 solution 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates using custom classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create a new deck and tell the deck to print itself
            Deck deck1 = new Deck();
            deck1.Print();
            // tell the deck to shuffle and print itself
            deck1.Shuffle();
            deck1.Print();
            // take the top card from the deck and print the card rank and suit
            Card card1 = deck1.TakeTopCard();
            Console.WriteLine("Rank: " + card1.Rank + " Suit: " + card1.Suit);
            // take the top card from the deck and print the card rank and suit
            Card card2 = deck1.TakeTopCard();
            Console.WriteLine("Rank: " + card2.Rank + " Suit: " + card2.Suit);

            Console.ReadLine();
        }
    }
}

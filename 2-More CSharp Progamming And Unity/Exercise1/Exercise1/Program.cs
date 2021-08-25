using System;
using ConsoleCards;

namespace Exercise1
{
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Practices using arrays
        /// </summary>
        /// <param name="args">command-line arguments</param>
        public static void Main(string[] args)
        {

            Deck dck = new Deck();
            Card[] cards = new Card[5];
            dck.Shuffle();
            cards[0] = dck.TakeTopCard();
            cards[0].FlipOver();
            cards[0].Print();
            
            cards[1] = dck.TakeTopCard();
            cards[1].FlipOver();
            cards[0].Print();
            cards[1].Print();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        static List<Card> firstPlayerCards = new List<Card>();
        static List<Card> secondPlayerCards = new List<Card>();
        static List<Card> thirdPlayerCards = new List<Card>();

        static Deck newDeck;

        const int beginCardAmmount = 2;
        static void Main(string[] args)
        {
            
            // print welcome message
            Console.WriteLine("Welcome");

            // create and shuffle a deck
            newDeck = new Deck();
            newDeck.Shuffle();
            newDeck.Cut(32);

            // deal 2 cards each to 3 players 
            if (newDeck != null)
                DealFirstCards();

            Console.WriteLine("Press Enter to continue or SpaceBar to add card");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                AddCardsToPlayers();              

            Console.WriteLine("Press Enter to continue or SpaceBar to add card");
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
                AddCardsToPlayers();

            // flip all the cards over
            FlipTheCards();

            //print players cards
            PrintTheCards();

            Console.WriteLine();
            Console.ReadLine();
        }

        static void DealFirstCards()
        {
            for (int i = 0; i <= beginCardAmmount; i++)
            {
                firstPlayerCards.Add(newDeck.TakeTopCard());
                secondPlayerCards.Add(newDeck.TakeTopCard());
                thirdPlayerCards.Add(newDeck.TakeTopCard());
            }
        }

        static void FlipTheCards()
        {
            foreach (Card card in firstPlayerCards)
                card.FlipOver();

            foreach (Card card in secondPlayerCards)
                card.FlipOver();

            foreach (Card card in thirdPlayerCards)
                card.FlipOver();
        }

        static void AddCardsToPlayers()
        {
            firstPlayerCards.Add(newDeck.TakeTopCard());
            secondPlayerCards.Add(newDeck.TakeTopCard());
            thirdPlayerCards.Add(newDeck.TakeTopCard());
            Console.WriteLine("Cards added \n");
        }

        static void PrintTheCards()
        {
            // print the cards for player 1
            Console.WriteLine("\nFirst Player Cards:");
            foreach (Card card in firstPlayerCards)
                Console.WriteLine(card.Rank + " of " + card.Suit);

            // print the cards for player 2
            Console.WriteLine("\nSecond Player Cards: ");
            foreach (Card card in secondPlayerCards)
                Console.WriteLine(card.Rank + " of " + card.Suit);

            // print the cards for player 3
            Console.WriteLine("\nThird Player Cards:");
            foreach (Card card in thirdPlayerCards)
                Console.WriteLine(card.Rank + " of " + card.Suit);
        }
    }
}

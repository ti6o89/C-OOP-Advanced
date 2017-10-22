using System;
using System.Collections.Generic;

namespace Problem_1.Card_Suit
{
    class StartUp
    {
        static void Main()
        {
            var firstPlayer = new Player(Console.ReadLine());
            var secondPlayer = new Player(Console.ReadLine());
            var deck = GenerateDeck();

            while (firstPlayer.Cards.Count != 5 || secondPlayer.Cards.Count != 5)
            {
                var args = Console.ReadLine().Split();

                try
                {
                    var card = new Card(args[0], args[2]);
                    if (deck.Contains(card))
                    {
                        deck.Remove(card);

                        if (firstPlayer.Cards.Count < 5)
                        {
                            firstPlayer.AddCard(card);
                        }
                        else
                        {
                            secondPlayer.AddCard(card);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("No such card exists.");
                }
            }

            if (firstPlayer.HighestPoweredCard().CompareTo(secondPlayer.HighestPoweredCard()) > 0)
            {
                Console.WriteLine($"{firstPlayer.Name} wins with {firstPlayer.HighestPoweredCard().Rank} of {firstPlayer.HighestPoweredCard().Suit}.");
            }
            else
            {
                Console.WriteLine($"{secondPlayer.Name} wins with {secondPlayer.HighestPoweredCard().Rank} of {secondPlayer.HighestPoweredCard().Suit}.");
            }
        }

        public static List<Card> GenerateDeck()
        {
            //string targetEnum = Console.ReadLine();
            List<Card> deck = new List<Card>();

            foreach (var suit in Enum.GetNames(typeof(Suit)))
            {
                foreach (var rank in Enum.GetNames(typeof(Rank)))
                {
                    var card = new Card(rank, suit);
                    deck.Add(card);
                }
            }
            return deck;
            //foreach (var card in deck)
            //{
            //    Console.WriteLine($"{card.Rank} of {card.Suit}");
            //}
        }

        public static void PrintSuit()
        {
            var input = Console.ReadLine();

            Console.WriteLine("Card Suits:");
            foreach (var item in Enum.GetValues(typeof(Suit)))
            {
                Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");
            }
        }

        public static void PrintRank()
        {
            var input = Console.ReadLine();

            Console.WriteLine("Card Ranks:");
            foreach (var item in Enum.GetValues(typeof(Rank)))
            {
                Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");
            }
        }
    }
}

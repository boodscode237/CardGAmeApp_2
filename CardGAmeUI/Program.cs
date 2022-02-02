using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGAmeUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }

    public abstract class Deck
    {
        public void CreateDeck()
        {

        }

        public void ShuffleDeck()
        {

        }
    }

    public class PlayingCard
    {
        public CardSuit Suit { get; set; }
        public CardValue Value { get; set; }
    }

    public enum CardValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public enum CardSuit
    {
        Hearts,
        Clubs,
        Diamonds,
        Spades
    }
}


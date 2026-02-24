using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Core
{
    internal class Deck
    {
        /// <summary>
        /// All cards in a deck
        /// </summary>
        public Stack<Card> Cards;
        /// <summary>
        /// Add cards to the deck
        /// </summary>
        /// <param name="card"></param>
        public Deck()
        {
            Cards = new Stack<Card>();
        }
        public void AddCard(Card card)
        {
            Cards.Push(card);
            Console.WriteLine($"Card added to deck.");
        }
        /// <summary>
        /// Remove cards from the deck
        /// </summary>
        /// <param name="card"></param>
        public void RemoveCard(Card card)
        {
            Cards.Pop();
            Console.WriteLine("Card removed from deck.");
        }
        /// <summary>
        /// Shuffles the deck
        /// </summary>
        public void Shuffle()
        {
            //Make a new random variable to use for variation
            Random r = new Random();
            //This temporary list is to put the cards in the deck somewhere for a moment while we shuffle
            //Like putting them in a shuffling machine, I think (those probably exist)
            List<Card> temp = new List<Card>();
            //The deck will have 52 cards, so run that many times to get them all
            for (int i = 0; i < 52; i++)
            {
                //Add the first card, then remove it
                temp.Add(Cards.Peek());
                Cards.Pop();
            }
            while (temp.Count() > 0)
            {
                //This makes sure that whatever random card gets chosen, that it's removed from the list
                //This way, I don't get duplicates (I hope)
                Card rand = temp[r.Next(temp.Count())];
                Cards.Push(rand);
                temp.Remove(rand);
            }
        }

    }
}

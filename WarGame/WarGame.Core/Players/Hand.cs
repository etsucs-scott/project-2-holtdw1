using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame.Core.Enums;
using WarGame.Core.Cards;
using WarGame.Core.Players;
using WarGame.Core.Game_Logic;

namespace WarGame.Core.Players
{
    public class Hand
    {
        /// <summary>
        /// The cards in a player's hand
        /// </summary>
        public Queue<Card> Cards;
        public Hand(Queue<Card> hand)
        {
            Cards = new Queue<Card>();
        }
        /// <summary>
        /// Add a card to the hand
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(Card card)
        {
            Cards.Enqueue(card);
        }
        /// <summary>
        /// Remove a card from a hand
        /// </summary>
        /// <param name="card"></param>
        public void RemoveCard()
        {
            Cards.Dequeue();
        }

    }
}

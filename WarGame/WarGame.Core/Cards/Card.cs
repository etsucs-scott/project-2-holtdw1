using System.Collections.Generic;
using WarGame.Core.Enums;
using WarGame.Core.Cards;
using WarGame.Core.Players;
namespace WarGame.Core.Cards
{
    public class Card
    {
        /// <summary>
        /// The number on a card
        /// </summary>
        public Rank Rank { get; set; }
        /// <summary>
        /// The picture on a card
        /// </summary>
        public Suit Suit { get; set; }

        public Card(Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }
    }
}

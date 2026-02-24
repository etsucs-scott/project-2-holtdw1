using System.Collections.Generic;
using WarGame.Core.Enums;
namespace WarGame.Core
{
    public class Card
    {
        public Rank Rank { get; set; }
        public Suit Suit { get; set; }

        public Card (Rank rank, Suit suit)
        {
            Rank = rank;
            Suit = suit;
        }
    }
}

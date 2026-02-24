using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame.Core.Enums;
using WarGame.Core.Cards;
using WarGame.Core.Players;
using WarGame.Core.Game_Logic;

namespace WarGame.Core.Game_Logic
{
    public class PlayedCards
    {
        /// <summary>
        /// Cards currently in play
        /// </summary>
        public Dictionary<string, Card> Cards;
        /// <summary>
        /// Holds which players played which cards
        /// </summary>
        /// <param name="player"></param>
        /// <param name="card"></param>
        public PlayedCards() 
        {
            Cards = new Dictionary<string, Card>();
        }
        /// <summary>
        /// Adds a new card at a player's index key
        /// </summary>
        /// <param name="player"></param>
        /// <param name="card"></param>
        public void AddCard(Player player, Card card)
        {
            Cards[player.Name] = card;
            Console.WriteLine($"{player.Name} played the {card.Rank} of {card.Suit}");
        }
    }
}

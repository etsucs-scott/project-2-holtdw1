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
    public class PlayedCards : Main
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
        public PlayedCards() //this tracks what player played what card
        {
            Cards = new Dictionary<string, Card>();
        }
        /// <summary>
        /// Adds a new card at a player's index key
        /// </summary>
        /// <param name="player"></param>
        /// <param name="card"></param>
        public void PlayCard(Player player, Card card)
        {
            Cards[player.Name] = card;
            Message = $"{player.Name} played the {card.Rank} of {card.Suit}";
        }
    }
}

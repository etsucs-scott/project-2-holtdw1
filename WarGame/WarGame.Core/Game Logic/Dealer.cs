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
    /// <summary>
    /// The dealer holds the dictonary of players
    /// </summary>
    public static class Dealer
    {
        /// <summary>
        /// Holds the names and object of the players
        /// </summary>
        public static Dictionary<string, Player> Players { get; set; }
        /// <summary>
        /// The deck of cards
        /// </summary>
        static Dealer()
        {
            Players = new Dictionary<string, Player>();
        }
        /// <summary>
        /// Shuffles the deck and deals cards to players
        /// </summary>
        public static void DealCards()
        {
            Deck.Shuffle();
            Game.Message = "Shuffled!";
            Game.Message = "Dealing cards...";
            while (Deck.Cards.Count > 0)
            {
                foreach (var player in Players)
                {
                    if (Deck.Cards.Count == 0)
                    {
                        break;
                    }
                    player.Value.PlayerHand.AddCard(Deck.Cards.Pop());
                }
            }
        }
    }
}

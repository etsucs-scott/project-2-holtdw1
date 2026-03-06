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
    public static class Pot
    {
        /// <summary>
        /// The cards in the pot
        /// </summary>
        public static List<Card> Cards;
        static Pot() //the pot will hold a list of cards to give to the winner. It doesn't care about who input the card
        {
            Cards = new List<Card>();
        }
        /// <summary>
        /// Adds a card to the pot
        /// </summary>
        /// <param name="card"></param>
        public static void AddCard(Card card)
        {
            Cards.Add(card);
        }
        /// <summary>
        /// Adds the pot to a player's queue
        /// </summary>
        /// <param name="player"></param>
        public static void WinCards(Player player)
        {
            foreach(Card card in Cards)//hopefully this will increment through the list, and operate on each card
            {
                player.PlayerHand.AddCard(card);
                Cards.Remove(card);
            }
        }
    }
}

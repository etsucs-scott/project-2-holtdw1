using WarGame.Core.Cards;
using WarGame.Core.Players;

namespace WarGame.Core.Game_Logic
{
    public static class PlayerHands
    {  
        /// <summary>
        /// Hands currently held
        /// </summary>
        public static Dictionary<string, Hand> Hands = new();
        /// <summary>
        /// Adds a new hand at a player's index key
        /// </summary>
        /// <param name="player"></param>
        /// <param name="card"></param>
        public static void AddHand(Player player, Hand hand)
        {
            Hands[player.Name] = hand;
        }

    }
}

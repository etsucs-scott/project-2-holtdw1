using WarGame.Core.Cards;
using WarGame.Core.Players;

namespace WarGame.Core.Game_Logic
{
    public class PlayerHands : Main
    {  
        /// <summary>
        /// Hands currently held
        /// </summary>
        public Dictionary<string, Hand> Hands;
        /// <summary>
        /// Holds which hand belongs to what player
        /// </summary>
        /// <param name="player"></param>
        /// <param name="card"></param>
        public PlayerHands()
        {
            Hands = new Dictionary<string, Hand>();
        }
        /// <summary>
        /// Adds a new hand at a player's index key
        /// </summary>
        /// <param name="player"></param>
        /// <param name="card"></param>
        public void AddHand(Player player, Hand hand)
        {
            Hands[player.Name] = hand;
            Message = $"{player.Name}'s hand created";
        }

    }
}

using WarGame.Core.Cards;
using WarGame.Core.Players;

namespace WarGame.Core.Game_Logic
{
    public static class PlayedCards
    {
        /// <summary>
        /// Cards currently in play
        /// </summary>
        public static Dictionary<string, Card> Cards;
        public static string Winner;
        /// <summary>
        /// Holds which players played which cards
        /// </summary>
        /// <param name="player"></param>
        /// <param name="card"></param>
        static PlayedCards() //this tracks what player played what card
        {
            Cards = new Dictionary<string, Card>();
        }
        /// <summary>
        /// Adds a new card at a player's index key
        /// </summary>
        /// <param name="player"></param>
        /// <param name="card"></param>
        public static void PlayCard(Player player, Card card)
        {
            Cards[player.Name] = card;
            Pot.AddCard(card);
        }
        /// <summary>
        /// Compares the cards, returns the winning player
        /// </summary>
        /// <param name="card1"></param>
        /// <param name="card2"></param>
        /// <returns></returns>
        public static List<KeyValuePair<string, Card>> CompareCards(Dictionary<string, Card> cards)
        {
            var highestRank = cards.Max(x => x.Value.Rank); //x is a temporary variable for a hidden loop, that extracts the rank
            var victors = cards //just for naming
                .Where(x => x.Value.Rank == highestRank) //looks at each Value, where the card is the same as the highest rank
                .ToList();//converts it to a list of key and value pairs
            if (victors.Count == 1)
            {
                return victors; //returns the winner and their card
            }
            else
            {
                var warmongers = victors.ToDictionary(victor => victor.Key, victor => victor.Value); //makes a dictionary 
                                                                                                    //for recursion
                return CompareCards(warmongers); //keeps running the method until there is but one winner
            }
        }
    }
}

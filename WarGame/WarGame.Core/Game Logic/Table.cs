using WarGame.Core.Cards;
using WarGame.Core.Players;


namespace WarGame.Core.Game_Logic
{
    /// <summary>
    /// Table handles all of the back-end player and card creation
    /// </summary>
    public static class Table
    {
        /// <summary>
        /// The amount of players specified
        /// </summary>
        public static int PlayerCount { get; set; }
        /// <summary>
        /// Initializes the deck, and creates each card. Then, shuffles them
        /// </summary>
        public static void MakeDeck()
        {
            for (int suit = 0; suit < 4; suit++)//my suits are labeled 0 to 3, so this should iterate once per suit
            {
                for (int rank = 2; rank < 15; rank++)//my ranks are labeled 2 to 14, so this should iterate once per rank, too
                {
                    Card card = new Card(rank, suit);//hopefully, this will make one card per rank per suit
                    Deck.AddCard(card);//add the new card to the deck, and the next loop would redefine "card"
                }
            }
        }
        /// <summary>
        /// Makes each player specified
        /// </summary>
        /// <param name="players"></param>
        public static void MakePlayers(int players, List<string> names)
        {
            Dealer.Players.Clear();
            PlayerCount = players; //declare the playercount to track how many there are
            int PlayersMade = 0;//make a temp variable to break the loop

            while (PlayersMade < PlayerCount)
            {
                for (int i = 0; i < players; i++)
                {
                    Player player = new Player(names[i]);
                    PlayersMade++;//this is here to make sure our loop breaks
                    Dealer.AddPlayer(names[i], player);//index the player's key and value to the dealer's dictonary 
                }
            }
        }
    }
}

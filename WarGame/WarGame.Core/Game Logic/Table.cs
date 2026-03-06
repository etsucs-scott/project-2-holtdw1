using WarGame.Core.Enums;
using WarGame.Core.Cards;
using WarGame.Core.Players;
using WarGame.Core.Game_Logic;
using System.Xml.Linq;
using System.Threading.Channels;


namespace WarGame.Core.Game_Logic
{
    public class Table
    {
        /// <summary>
        /// The amount of players specified
        /// </summary>
        public int PlayerCount { get; set; }
        /// <summary>
        /// Initializes the deck, and creates each card. Then, shuffles them
        /// </summary>
        public void MakeDeck()
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
        public void MakePlayers(int players)
        {
            Game.Message = "This will remove all current players, and allow (re)creation. Are you sure? (Y/N)";
            if (Game.Input.ToUpper() == "Y" || Game.Input.ToUpper() == "YES")
            {
                Dealer.Players.Clear();
                PlayerCount = players; //declare the playercount to track how many there are
                int PlayersMade = 0;//make a temp variable to break the loop

                while (PlayersMade < PlayerCount)
                {
                    Game.Prompt = $"Enter player name: "; //this is for implimentation later on, should the output not be a console
                    Game.Input = null;//I can take in input at this point later, but null is used to prevent errors for now
                    Player player = new Player(Game.Input, null);
                    PlayersMade++;//this is here to make sure our loop breaks
                    Dealer.Players.Add(Game.Input, player);//index the player's key and value to the dealer's dictonary
                    Game.Message = $"{Game.Input} added to the game! Players created: {PlayersMade} / {PlayerCount}";
                }
            }
            else
            {
                Game.Message = "Process aborted.";
            }
        }
        /// <summary>
        /// Removes a player at their key value
        /// </summary>
        /// <param name="player"></param>
        public void RemovePlayer(Player player)
        { 
            if (PlayerCount >= 1)
            {
                Game.Prompt = $"Enter the name of the player you want to remove: (Case sensitive)";
                Game.Input = null;
                if (Dealer.Players.ContainsKey(Game.Input))
                {
                    Dealer.Players.Remove(Game.Input); //prompt the user in the console to insert the name
                    PlayerCount--;
                    Game.Message = $"Player: {Game.Input} removed.";
                }
                else
                {
                    Game.Message = $"The player ({Game.Input}) doesn't exist. Try again, or check case and spelling";
                }
            }
            else
            {
                Game.Message = "You don't have any players yet.";
            }
        }
    }
}

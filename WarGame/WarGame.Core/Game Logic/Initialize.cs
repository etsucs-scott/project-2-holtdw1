using WarGame.Core.Enums;
using WarGame.Core.Cards;
using WarGame.Core.Players;
using WarGame.Core.Game_Logic;
using System.Xml.Linq;
using System.Threading.Channels;


namespace WarGame.Core.Game_Logic
{
    internal class Table //have this class make each card and shuffle to initialize the deck, and make player objects
    {
        /// <summary>
        /// The amount of players specified
        /// </summary>
        public int PlayerCount { get; set; }
        /// <summary>
        /// The message that displays for user comprehension
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Handles any questions needed to ask the user
        /// </summary>
        public string Prompt { get; set; }
        /// <summary>
        /// Holds any user input
        /// </summary>
        public string Input { get; set; }
        public Dealer Dealer { get; set; }
        public Table()
        {
            Dealer = new Dealer();
        }
        /// <summary>
        /// Initializes the deck, and creates each card. Then, shuffles them
        /// </summary>
        public void MakeDeck()
        {
            Deck deck = new Deck();//actually make the deck object

            for (int suit = 0; suit < 4; suit++)//my suits are labeled 0 to 3, so this should iterate once per suit
            {
                for (int rank = 2; rank < 15; rank++)//my ranks are labeled 2 to 14, so this should iterate once per rank, too
                {
                    Card card = new Card(rank, suit);//hopefully, this will make one card per rank per suit
                    deck.AddCard(card);//add the new card to the deck, and the next loop would redefine "card"
                }
            }
            deck.Shuffle();
        }
        /// <summary>
        /// Makes each player specified
        /// </summary>
        /// <param name="players"></param>
        public void MakePlayers(int players)
        {
            Message = "This will remove all current players, and allow recreation. Are you sure? (Y/N)";
            if (Input.ToUpper() == "Y" || Input.ToUpper() == "YES")
            {
                Dealer.Players.Clear();
                PlayerCount = players; //declare the playercount to track how many there are
                int PlayersMade = 0;//make a temp variable to break the loop

                while (PlayersMade < PlayerCount)
                {
                    Prompt = $"Enter player name: "; //this is for implimentation later on, should the output not be a console
                    Input = null;//I can take in input at this point later, but null is used to prevent errors for now
                    Player player = new Player(Input, null);
                    PlayersMade++;//this is here to make sure our loop breaks
                    Dealer.Players.Add(Input, player);//index the player's key and value to the dealer's dictonary
                    Message = $"{Input} added to the game! Players created: {PlayersMade} / {PlayerCount}";
                }
            }
            else
            {
                Message = "Process aborted.";
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
                Prompt = $"Enter the name of the player you want to remove: (Case sensitive)";
                Input = null;
                if (Dealer.Players.ContainsKey(Input))
                {
                    Dealer.Players.Remove(Input); //prompt the user in the console to insert the name
                    PlayerCount--;
                    Message = $"Player: {Input} removed.";
                }
                else
                {
                    Message = $"The player ({Input}) doesn't exist. Try again, or check case and spelling";
                }
            }
            else
            {
                Message = "You don't have any players yet.";
            }
        }
    }
}

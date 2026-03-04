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
    public class Main
    {
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
        public int PlayerCount { get; set; }
        public Dealer Dealer { get; set; }
        public Deck Deck { get; set; } 
        public PlayedCards PlayedCards { get; set; }
        public PlayerHands PlayerHands { get; set; }
        public Main()
        {
            Dealer = new Dealer();//table already contains a dealer object, no need to make a new one. It also creates my players

            Deck = new Deck();//deck contains a stack of cards, as well as handling creation of cards

            PlayedCards = new PlayedCards();

            PlayerHands = new PlayerHands();
        }
        public void Compile()
        {
            MakeDeck();
            MakePlayers(PlayerCount);

        }
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
                    Dealer.Deck.AddCard(card);//add the new card to the deck, and the next loop would redefine "card"
                }
            }
        }

        /// <summary>
        /// Makes each player specified
        /// </summary>
        /// <param name="players"></param>
        public void MakePlayers(int players)
        {
                Dealer.Players.Clear();
                PlayerCount = players; //declare the playercount to track how many there are
                int PlayersMade = 0;//make a temp variable to break the loop

                while (PlayersMade < PlayerCount)
                {
                    Player player = new Player(Input, null);
                    PlayersMade++;//this is here to make sure our loop breaks
                    Dealer.Players.Add(Input, player);//index the player's key and value to the dealer's dictonary
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


        /*
         In main, I want to hold all of the logic. So I should define a general message system, with inputs and prompts. 
        That way, each class can use Main.Message, and the likes, instead of hard-coding Console.[whatever]. 
        
        All game logic should work together here, and the class should be able to compile all of the game, and run the logic needed

        What the class should not handle is the user interface side of things. That will be done in WarGane.Console
         */
    }
}

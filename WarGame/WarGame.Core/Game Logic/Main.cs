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
        public Table Table { get; set; }
        public Deck Deck { get; set; } 
        public Main()
        {
            Table = new Table();//table already contains a dealer object, no need to make a new one. It also creates my players

            Deck = new Deck();//deck contains a stack of cards, as well as handling creation of cards
        }
        public void Compile()
        {
            Message = "Creating deck...";
            Table.MakeDeck();
            Message = "Deck created!";

            Message = "Creating players...";
            Prompt = "How many players do you want? (2-4)";
            if (Input == "2" || Input.ToUpper() == "TWO")
            {
                Table.MakePlayers(2);
            }
            else if (Input == "3" || Input.ToUpper() == "THREE")
            {
                Table.MakePlayers(3);
            }
            else if (Input == "4" || Input.ToUpper() == "FOUR")
            {
                Table.MakePlayers(4);
            }
            else
            {
                Message = "Input was out of bounds or mispelled. Please try again";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Core.Game_Logic
{
    internal class Main
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
        
        /*
         In main, I want to hold all of the logic. So I should define a general message system, with inputs and prompts. 
        That way, each class can use Main.Message, and the likes, instead of hard-coding Console.[whatever]. 
        
        All game logic should work together here, and the class should be able to compile all of the game, and run the logic needed

        What the class should not handle is the user interface side of things. That will be done in WarGane.Console
         */
    }
}

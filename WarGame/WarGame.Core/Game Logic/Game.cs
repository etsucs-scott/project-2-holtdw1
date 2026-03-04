using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Core.Game_Logic
{
    public static class Game
    {
        /// <summary>
        /// The message that displays for user comprehension
        /// </summary>
        public static string Message { get; set; }
        /// <summary>
        /// Handles any questions needed to ask the user
        /// </summary>
        public static string Prompt { get; set; }
        /// <summary>
        /// Holds any user input
        /// </summary>
        public static string Input { get; set; }
    }
}

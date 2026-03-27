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
        /// Holds any user input
        /// </summary>
        public static string Input { get; set; }
        /// <summary>
        /// Makes the game work
        /// </summary>
        public static bool Functional { get; set; }
        /// <summary>
        /// Shows the winner
        /// </summary>
        public static bool Winner { get; set; }
        /// <summary>
        /// Limit of rounds to prevent infinite loops
        /// </summary>
        public static int RoundLimit { get; set; }
    }
}

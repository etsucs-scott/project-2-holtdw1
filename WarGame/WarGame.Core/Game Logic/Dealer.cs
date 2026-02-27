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
    /// <summary>
    /// The dealer holds the dictonary of players
    /// </summary>
    internal class Dealer
    {
        /// <summary>
        /// Holds the names and object of the players
        /// </summary>
        public Dictionary<string, Player> Players { get; set; }
        public Dealer()
        {
            Players = new Dictionary<string, Player>();
        }
    }
}

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
    internal class Dealer
    {
        public int PlayerCount { get; set; }
        public Dictionary<string, Player> Players { get; set; }
        public Dealer()
        {
            Players = new Dictionary<string, Player>();
            PlayerCount = Players.Count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame.Core.Enums;
using WarGame.Core.Cards;
using WarGame.Core.Players;
using WarGame.Core.Game_Logic;

namespace WarGame.Core.Players
{
    public class Player
    {
        /// <summary>
        /// The name of a player
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The hand of a player
        /// </summary>
        public Hand PlayerHand { get; set; }
        /// <summary>
        /// If the player is eliminated
        /// </summary>
        public bool Eliminated { get; set; }
        public int ID { get; set; }
        public Player(string name, int id) 
        {
            Name = name;
            ID = id;
            PlayerHand = new(new Queue<Card>());
        }
    }
}

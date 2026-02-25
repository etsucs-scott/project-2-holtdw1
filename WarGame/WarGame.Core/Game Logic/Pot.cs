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
    public class Pot
    {
        /// <summary>
        /// The cards in the pot
        /// </summary>
        public List<Card> Cards;
        public Pot()
        {
            Cards = new List<Card>();
        }
    }
}

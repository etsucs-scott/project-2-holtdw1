using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame.Core.Enums;
using WarGame.Core.Cards;
using WarGame.Core.Players;

namespace WarGame.Core.Players
{
    internal class Player
    {
        public string Name { get; set; }
        public Hand PlayerHand { get; set; }
    }
}

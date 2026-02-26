using WarGame.Core.Enums;
using WarGame.Core.Cards;
using WarGame.Core.Players;
using WarGame.Core.Game_Logic;
using System.Xml.Linq;
using System.Threading.Channels;


namespace WarGame.Core.Game_Logic
{
    internal class Initialize //have this class make each card and shuffle to initialize the deck, and make player objects
    {
        public int PlayerCount { get; set; }
        public List<Player> Players { get; set; }
        public Initialize()
        {
            PlayerCount = Players.Count;
        }
        /// <summary>
        /// Initializes the deck, and creates each card. Then, shuffles them
        /// </summary>
        public void MakeDeck()
        {
            Deck deck = new Deck();//actually make the deck object

            for (int suit = 0; suit < 4; suit++)//my suits are labeled 0 to 3, so this should iterate once per suit
            {
                for (int rank = 2; rank < 15; rank++)//my ranks are labeled 2 to 14, so this should iterate once per rank, too
                {
                    Card card = new Card(rank, suit);//hopefully, this will make one card per rank per suit
                    deck.AddCard(card);//add the new card to the deck, and the next loop would redefine "card"
                }
            }
            deck.Shuffle();
        }
        /// <summary>
        /// Makes each player specified
        /// </summary>
        /// <param name="players"></param>
        public void MakePlayers(int players)
        {
            PlayerCount = players;
            int PlayersMade = 0;
            Dealer dealer = new Dealer();

            while (PlayersMade < PlayerCount)
            {
                Console.WriteLine($"Enter player name: ");
                string name = Console.ReadLine();
                Player player = new Player(name, null);
                PlayersMade++;
                Console.WriteLine($"Players created: {PlayersMade} / {PlayerCount}");
            }
            foreach (Player player in Players)
            {
                //make player
            }
        }
    }
}

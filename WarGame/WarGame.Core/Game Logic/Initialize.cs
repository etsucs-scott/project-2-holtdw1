using WarGame.Core.Enums;
using WarGame.Core.Cards;
using WarGame.Core.Players;
using WarGame.Core.Game_Logic;


namespace WarGame.Core.Game_Logic
{
    internal class Initialize //have this class make each card and shuffle to initialize the deck
    {
        /* Thinking out loud, as I'm not sure how to do this yet
         * 
         * I should make each card. So I need a loop that runs, and makes each card only once
         * It doesn't have to be random, so I could hard code each card; I probably shouldn't
         * 
         * I could go by suit: for diamonds, make one of each rank, then move on to the next suit. 
         */
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
        }
    }
}

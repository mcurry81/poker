using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Deck
    {
        public Card[] deck = new Card[52];
        int index = 0;
        public int deckCount = 0;

        public Deck()
        {
            foreach (char suit in new[] { 'C', 'D', 'H', 'S' })
            {
                for (int rank = 2; rank <= 14; rank++)
                 {
                    deck[index++] = new Card(suit, rank);
                 }
            }
         }

        public void shuffle(Deck[] deck)
        {
            //Fisher-Yates Shuffle Method
            Random r = new Random();
            for (int n = deck.Length - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                var temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;

            }
         }

        public void drawCard(Deck[] deck)
        {
            List<Deck> deckList = deck.ToList();
            deckList.RemoveAt(0);

            Array.Resize(ref deck, deck.Length - 1);
            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = deckList[i];
            }
        }

        public int cardsInDeck(Card[] deck)
        {
            int i = deck.Length;
            foreach ( )
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Deck
    {
        public Card[] cards = new Card[53];
        int i = 1;
        //int cardCount = 0;

        public Deck()
        {
            foreach (char suit in new[] { 'C', 'D', 'H', 'S' })
            {
                for (int rank = 2; rank <= 14; rank++)
                 {
                    // Console.WriteLine("BCard" + index + ":" + cards[index]);
                    cards[i++] = new Card(suit, rank);
                    
      
                }
            }
         }

        /*  public static void printCards(Card[] cards)
          {
              for(int i = 1; i < cards.Length; i++)
              {
                  for(int j = 0; j < 4; j++)
                  {
                      Console.WriteLine("Card({0})={1}", i, cards[i + j]);
                  }
              }

          }*/

        public void printCards()
        { 
            for(int i = 1; i < cards.Length; i++)
            {
                Console.WriteLine("Card" + i + ":" + cards[i].getSuit() + cards[i].getRank());
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

         /*public int cardsInDeck(Card[] deck)
         {
             int i = deck.Length;
             foreach ( )
         }*/
    }
}

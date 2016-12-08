using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Deck
    {
        public Card[] deck;
        int currentCard;
        int cardCount = 0;

        /// <summary>
        /// Constructor for Deck, creates a Deck object, which consists of an 
        /// array of 52 Card objects, and assigns each a suit and rank.
        /// </summary>
        public Deck()
        {
            //set currentCard to the first card in deck
            currentCard = 1;
            int i = 1;
            deck = new Card[52];
            foreach(SUIT s in Enum.GetValues(typeof(SUIT)))
            {
                foreach(RANK r in Enum.GetValues(typeof(RANK)))
                {
                    deck[i++] = new Card(r, s);
                    cardCount++;
                }
            }

        }


        /// <summary>
        /// Constructor for testing only
        /// </summary>
        /// <param name="count"></param>
        public Deck(int count)
        {
            deck = new Card[count];

        }

        /// <summary>
        /// Indexer to allow deck to be accessed more easily
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Card this[int index]
        {
            get
            {
                return deck[index];
            }
        }

        protected void addCard(RANK rank, SUIT suit, int index)
        {
            deck[index] = new Poker.Card(rank, suit);
        }

        /// <summary>
        /// Returns the next card in the deck and increments counter to get the 
        /// next card in deck.
        /// </summary>
        /// <returns>deck[currentCard]</returns>
        public Card dealCard()
        {
            cardCount--;
            return deck[currentCard++];
        }


        /// <summary>
        /// Usign the number of cards needed for a hand, the dealHand method will create an array of Cards
        /// that will be created from the deck using the dealCard method. Returns the array of Cards.
        /// </summary>
        /// <param name="numOfCards"></param>
        /// <returns>dealtHand</returns>
        public Hand dealHand(int numOfCards)
        {
            Card[] dealtHand = new Card[numOfCards];

            for(int i = 0; i < numOfCards; i++)
            {
                dealtHand[i] = this.dealCard();
            }

            return dealtHand;
        }
 

        /// <summary>
        /// Shuffle method shuffles the order of the cards using
        /// the Fisher Yates method and resets the next
        /// card in deck to the first card. 
        /// </summary>
        public void shuffle()
        {
            //reset next card in deck to the first card
            currentCard = 1;

            //Fisher-Yates Shuffle Method

            //random shuffle variable
            Random r = new Random();
            for (int n = deck.Length - 1; n > 1; --n)
            {
                int k = r.Next(n + 1);
                var temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;

            }
        }

        /// <summary>
        /// Prints all cards in deck object both in play and not yet in play.
        /// </summary>
        public void printAllCards()
        {
            foreach(Card c in deck)
            {
                Console.WriteLine(c);
            }
        }


        /// <summary>
        /// Prints all cards remaining in deck.
        /// </summary>
        public void printRemainingCards()
        {
            for(int i = currentCard; i < deck.Length; i++)
            {
                Console.WriteLine(deck[i]);
            }
        }


        /// <summary>
        /// Returns the number of cards left in the deck to play.
        /// </summary>
        /// <returns>number of cards in deck</returns>
        public int getDeckCount()
        {
            return deck.Length - currentCard;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Hand
    {
        Card[] hand;
        int maxCards;

        public Hand(int maxCards)
        {
            this.maxCards = maxCards;
        }

        public void addCard(Card card)
        {
            if (hand.Length < maxCards)
            {
                hand[hand.Length] = card;
            }
            else
            {
                throw new ArgumentException("User already holds max number in hand");
            }
        }

        public Card[] getHand()
        {
            return hand;
        }

        public int getValue()
        {
           if (hand.Length == maxCards)
            {
                return 100;
                /*bool isFlush = true;
                Dictionary<int, int> myHand = new Dictionary<int, int>();
                
                for (int i = 0; i < hand.Length; i++)
                {
                    if (i > 0 && hand[i].suit != hand[i - 1].suit)
                        isFlush = false;

                    if (myHand.ContainsKey(hand[i].rank)
                        myHand[hand[i].rank]++;
                    else
                        myHand.Add(hand[i].rank, 1);
                    {



                    }

                }
                
                 
             */     
            } 
           else
            {
                throw new ApplicationException("player does not have a complete hand");
            }
        }
    }
}

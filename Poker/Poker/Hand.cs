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

            }
            else
            {
                throw new ArgumentException("User already holds max number in hand");
            }
        }

        public void removeCard(Card card)
        {
            if (hand.Length > 0)
            {

            }
            else
            {
                throw new ArgumentException("User has no cards in hand");
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
                
            } 
           else
            {
                throw new ApplicationException("player does not have a complete hand");
            }
        }
    }
}

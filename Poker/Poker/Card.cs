using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Card
    {
        // S, H, D, or C
        public char suit;
        // 2 = 2...J=11, Q=12, K=13, A=14
        public int rank;

        //constructor to create a card with suit and rank
        public Card(char suit, int rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        bool isValid()
        {
            return suit != '\0' && rank >= 2 && rank <= 14;
        }
    }
}

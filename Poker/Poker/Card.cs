using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Card : IComparable
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

        //card constructor for manual construction
        public Card(string str)
        {
            str = str.ToUpper();
            foreach (char c in str)
            {
                switch (c)
                {
                    case 'C':
                    case 'D':
                    case 'H':
                    case 'S':
                        suit = c;
                        break;
                    case 'T':
                        rank = 10;
                        break;
                    case 'Q':
                        rank = 12;
                        break;
                    case 'K':
                        rank = 13;
                        break;
                    case 'J':
                        rank = 11;
                        break;
                    case 'A':
                        rank = 14;
                        break;
                    case '9':
                    case '8':
                    case '7':
                    case '6':
                    case '5':
                    case '4':
                    case '3':
                    case '2':
                        rank = c - '0';
                        break;


                }
            }
            if (rank == 0)
                Console.WriteLine("Hey dummy, please give your card's rank from " + str);

            //changed this from if(suit == 0) to comply more strictly with C# and prevent any possible future errors
            if (suit == '\0')
                Console.WriteLine("Hey dummy, please enter your suit from " + str);

        }

        bool isValid()
        {
            return suit != '\0' && rank >= 2 && rank <= 14;
        }

        public int CompareTo(object obj)
        {
            Card c = obj as Card;
            return rank - c.rank;
            throw new NotImplementedException();
        }

        public int getRank()
        {
            return rank;
        }

        public char getSuit()
        {
            return suit;
        }
    }
}

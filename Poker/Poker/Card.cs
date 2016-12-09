using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    /// <summary>
    /// Suit of Card
    /// </summary>
    public enum SUIT
    {
        Clubs,
        Diamonds,
        Hearts,
        Spaids
    }

    /// <summary>
    /// Rank of Card
    /// </summary>
    public enum RANK
    {
        Two=2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack = 11,
        Queen,
        King,
        Ace     //this value could be a one as well if it is in a A-5 straight
    }


    /*
     * TODO: Delete this enum if we decide to not use this. 
     * Odds of getting each hand are commented next to each hand
    enum HANDEVAL
    {
        Singles,        //1 in 2
        Pair,           //1 in 2.36
        TwoPair,        //1 in 21
        Trips,          //1 in 47
        Straight,       //1 in 255
        Flush,          //1 in 509
        FullHouse,      //1 in 694
        FourOfAKind,    //1 in 4165  
        StraightFlush,  // 1 in 72,192
        RoyalFlush     //1 in 649740
    }
    */


    public class Card : IComparable
    {

        public RANK _rank;
        public SUIT _suit;



        //constructor to create a card with suit and rank
        public Card(RANK rank, SUIT suit)
        {
            this._suit = suit;
            this._rank = rank;
        }

        public RANK rank
        {
            get
            {
                return _rank;
            }
        }

        public SUIT suit
        {
            get
            {
                return _suit;
            }
        }

        public override string ToString()
        {
            return this._rank + " of " + this._suit;
        }

        public int CompareTo(object obj)
        {
            Card c = obj as Card;
            return _rank - c.rank;
            throw new NotImplementedException();
        }

        public static implicit operator Card(Deck v)
        {
            throw new NotImplementedException();
        }

        /*
         * TODO: Not sure if we'll need this...can delete if not. 
        /// <summary>
        /// Creating an indexer for the Card class
        /// </summary>
        public Card(): this(RANK.None, SUIT.None)
        {

        }
        */

        /*
        * TODO: Delete this code if enums method works better
        * Commenting out...going to try to use enums instead
       // S, H, D, or C
       // public char suit;
       // 2 = 2...J=11, Q=12, K=13, A=14
       //public int rank;


           public int rank;
           public char suit;
           */


        /*
         * TODO: Delete this constructor, we shouldn't need to manually create cards
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
        */

        /*
         * TODO: Old  methods before changed to enums...delete if we stick with enums
    public bool isValid()
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

    public void  setSuit(char suit)
    {
        this.suit = suit;
    }

    public void  setRank(int rank)
    {
        this.rank = rank;
    }
    */
    }
}

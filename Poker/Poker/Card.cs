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
        Two = 2,
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


    }
}

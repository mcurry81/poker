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

        //generic constructor
        public Card()
        {
            //TODO: create card radomized
        }

        //card constructor
        public Card(string str)
        {
            str = str.ToUpper();
            foreach(char c in str)
            {
                switch(c)
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
    }


    class Program
    {


        static Card[] deck = null;
        static int dealIndex = 0;
        
        static void Main(string[] args)
        {
            
            Card[] hand = getHand(args);
            /*Card[] hand = new Card[5];
            hand[0] = new Card();
            hand[0].suit = 'C';
            hand[0].rank = 8;
            //more to come
            hand[0].suit = (char)Console.Read();
            //hand[0].rank = int.Parse(Console.Read());*/
            //sort hands
            Array.Sort(hand);
            int pairCount = getPairCount(hand);


            //need helper function to determine what type of hand my hand is
            if(isRoyalFlush(hand))
            {
                Console.WriteLine("Royal Flush");
            }
            if (isStraightFlush(hand))
             {
                 Console.WriteLine("straight flush"); //TODO
             }
            
           else if (isFourOfKind(hand))
             {
                Console.WriteLine("Four of a kind");
             }
            else if (isFullHouse(hand))
            {
                Console.WriteLine("Full House");
            }
            else if (isFlush(hand))
            {
                Console.WriteLine("Flush");
            }
            else if (isStraight(hand))
            {
                Console.WriteLine("Straight");
            }
            else if isTrips(hand))
            {
                Console.WriteLine("Trips");
            }
            else if(isTwoPair(pairCount))
            {
                Console.WriteLine("Two pair");
            }
            else if (isPair(pairCount))
            {
                Console.WriteLine("Pair");
            }
            else
            {
                Console.WriteLine(hand[0].rank + " high");
            }
        }

        static Card[] getHand(string[] args)
        {
            Card[] hand = new Card[5];
            int index = 0;
            foreach(string a in args)
            {
                if (index >= 5)
                    break;
                Card c = new Card(a);
                hand[index++] = c;
            }
            while(index < 5)
            {
                hand[index++] = deal();
            }
            return hand;
        }

        static Card deal()
        {
            if(deck == null || dealIndex >= 52)
            {
                deck = new Card[52];
                int index = 0;
                //TODO: one of each card

                //TODO: shuffle
            }
            return deck[dealIndex++];
        }

        //is a Royal Flush if it is a straight flush and the first card's rank is a 10
        static bool isRoyalFlush(Card[] hand)
        {
            return (isStraightFlush(hand)) && (hand[0].rank == 10); 
          
        }

        // is a straight flush if is a straight and a flush
        static bool isStraightFlush(Card[] hand)
        {
            return isFlush(hand) && isStraight(hand);
        }

        //is four of a kind
        static bool isFourOfKind(Card[] hand)
        {
            int count = 0;
            while(count < 4 && hand[count].rank == hand[count + 1].rank)
            {
                count++;
            }
            if(count == 4){
                return true;
            }
            return false; 
        }

        //TODO: isFullHouse
        static bool isFullHouse(Card[] hand)
        {
            return isTrips(hand) && isTwoPair(pairCount);
        }

        static bool isFlush(Card[] hand)
         {
             //check if cards 1-4 match the suit of card 0
             for(int i = 1; i < hand.Length; i++)
              {
                  if (hand[i].suit != hand[0].suit)
                  return false;
               }
              return true;
          }
        static bool isStraight(Card[] hand)
        {
         //check if cards are sequential 
         //assuming cards in hand are sorted
            for(int i = 1; i < hand.Length; i++)
             {
                if (hand[i].rank != hand[i - 1].rank + 1)
                   return false;
              }
              return true;
            }

        //is three of a kind
        static bool isTrips(Card[] hand)
        {
            for(int i = 0; i < hand.Length - 2; i++)
            {
                if(hand[i].rank == hand[i+ 2].rank)
                {
                    return true;
                }
            }
            return false;
        }

        //is two pairs
        static bool isTwoPair(int pairCount)
        {
            if(pairCount != 2)
            {
                return false;
            }
            return true;
        }

        //is a pair
        static bool isPair(int pairCount)
        {
            if(pairCount != 1)
            {
                return false;
            }
            return true;
        }

        //get pair count to determine if one pair or two pairs
         static int getPairCount(Card[] hand)
        {
            int numOfPair = 0;
            for (int i = 0; i < hand.Length; i++)
            {
                if (hand[i].rank == hand[i + 1].rank)
                {
                    numOfPair++;
                }
            }
            return numOfPair;
        }
      /*  static int getIndexOfPair(Card[] hand)
        {
            if 
        } */
    }
}

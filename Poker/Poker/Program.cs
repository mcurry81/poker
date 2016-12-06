using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{

    class Program
    {


        static Card[] deck = null;
       // static int dealIndex = 0;

        static void Main(string[] args)
        {
            Deck newDeck = new Deck();

            ///to show deck has been properly created. 
            Console.WriteLine("Cards in Deck:");
            newDeck.printCards();




            //sort hands*/
            /*   Array.Sort(cards);
               int pairCount = getPairCount(cards);


               //need helper function to determine what type of cards my cards is
               if(isRoyalFlush(cards))
               {
                   Console.WriteLine("Royal Flush");
               }
               if (isStraightFlush(cards))
                {
                    Console.WriteLine("straight flush"); //TODO
                }

              else if (isFourOfKind(cards))
                {
                   Console.WriteLine("Four of a kind");
                }
               else if (isFullHouse(cards, pairCount))
               {
                   Console.WriteLine("Full House");
               }
               else if (isFlush(cards))
               {
                   Console.WriteLine("Flush");
               }
               else if (isStraight(cards))
               {
                   Console.WriteLine("Straight");
               }
               else if (isTrips(cards))
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
                   Console.WriteLine(cards[0].rank + " high");
               }
           }

           static Card[] getHand(string[] args)
           {
               Card[] cards = new Card[5];
               int index = 0;
               foreach(string a in args)
               {
                   if (index >= 5)
                       break;
                   Card c = new Card(a);
                   cards[index++] = c;
               }
               while(index < 5)
               {
                   cards[index++] = deal();
               }
               return cards;
           }

           static Card deal()
           {
               if(deck == null || dealIndex >= 52)
               {
                   deck = new Card[52];
                   //int index = 0;
                   //TODO: one of each card

                   //TODO: shuffle
               }
               return deck[dealIndex++];
           }

           //is a Royal Flush if it is a straight flush and the first card's rank is a 10
           static bool isRoyalFlush(Card[] cards)
           {
               return (isStraightFlush(cards)) && (cards[0].rank == 10); 

           }

           // is a straight flush if is a straight and a flush
           static bool isStraightFlush(Card[] cards)
           {
               return isFlush(cards) && isStraight(cards);
           }

           //is four of a kind
           static bool isFourOfKind(Card[] cards)
           {
               int count = 0;
               while(count < 4 && cards[count].rank == cards[count + 1].rank)
               {
                   count++;
               }
               if(count == 4){
                   return true;
               }
               return false; 
           }

           //TODO: isFullHouse
           static bool isFullHouse(Card[] cards, int pairCount)
           {
               return isTrips(cards) && isTwoPair(pairCount);
           }

           static bool isFlush(Card[] cards)
            {
                //check if cards 1-4 match the suit of card 0
                for(int i = 1; i < cards.Length; i++)
                 {
                     if (cards[i].suit != cards[0].suit)
                     return false;
                  }
                 return true;
             }
           static bool isStraight(Card[] cards)
           {
               int len = cards.Length;
               //if last card is an A, and first card is a 2, then only check cards cards excluding last card for straight
               if (cards[cards.Length - 1].rank == 14 && cards[0].rank == 2)
                   len--;

                //check if cards are sequential 
                //assuming cards in cards are sorted
               for(int i = 1; i < len; i++)
                {
                   if (cards[i].rank != cards[i - 1].rank + 1)
                       return false; 
                 }
                 return true;
             }

           //is three of a kind
           static bool isTrips(Card[] cards)
           {
               for(int i = 0; i < cards.Length - 2; i++)
               {
                   if(cards[i].rank == cards[i+ 2].rank)
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
            static int getPairCount(Card[] cards)
           {
               int numOfPair = 0;
               for (int i = 0; i < cards.Length; i++)
               {
                   if (cards[i].rank == cards[i + 1].rank)
                       numOfPair++;
               }
               return numOfPair;
           }
           static int countOfACard(Card[] cards)
           {
               int[] ranks = new int[];
               int[] ofAKind = new int[];
               foreach(Card c in cards)
               {
                   ranks[c.rank]++;
                   ofAKind[ranks[c.rank]]++;
               }

               if (ofAKind[4] > 0)
                   return 4;
               if (ofAKind[3] > 0 && ofAKind[2] > 1)
                   return 32;

           }
         /*  static int getIndexOfCard(Card[] cards)
           {
               if 
           } */
        }
    }
}

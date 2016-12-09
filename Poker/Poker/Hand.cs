using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Hand
    {
        public Card[] hand;
        int maxCards;
        HAND_VALUE value;
        int tiebreak = 0;


        public enum HAND_VALUE
        {
            High_Card,
            Pair,
            Two_Pair,
            Three_of_a_Kind,
            Straight,
            Flush,
            Full_House,
            Four_of_a_Kind,
            Straight_Flush,
            Royal_Flush
        }

        public Hand(int maxCards)
        {
            this.maxCards = maxCards;
        }

       public void addCard(Card card)
        {
            Console.WriteLine(maxCards);
            Console.WriteLine(hand.Length);
            if (hand.Length < maxCards)
            {
                hand[hand.Length] = card;
            }
            else
            {
                throw new ArgumentException("User already holds max number in hand");
            }
        }

       /* public void addCard(Card card)
        {
            int count = 0;
            if(count < maxCards)
            {
                hand[hand.count] = card;
                count++;
            }
            else
            {
                throw new ArgumentException("User already holds max number in hand");
            }
        }*/

        public Card[] getHand()
        {
            return hand;
        }

        public int getTiebreak()
        {
            if (tiebreak > 0)
                return tiebreak;
            else
            {
                string result = "";
                string end = "";
                for (int i = hand.Length - 1; i > 0; i--)
                {
                    string current = ((int)hand[i].rank + 10).ToString();
                    if (hand[i].rank == hand[i - 1].rank)
                    {
                        result += current;
                        i--;
                    }
                    else
                        end += current;
                }
                return tiebreak = Int32.Parse(result + end);
            }
        }

        public HAND_VALUE getValue()
        {
            if (hand.Length == maxCards)
            {
                //
                bool isFlush = true;
                bool consec = true;
                RANK? isStraight = null;
                RANK? isTrips = null;
                RANK? isPair = null;
                RANK? isTwoPair = null;
                RANK? isQuad = null;

                //create a dictionary for possible quads, trips or pairs
                Dictionary<RANK, int> myHand = new Dictionary<RANK, int>();

                for (int i = 0; i < hand.Length; i++)
                {
                    //checking to see if all cards are same suit
                    if (i > 0 && hand[i].suit != hand[i - 1].suit)
                        isFlush = false;

                    //checking to see if cards rank consecutively for a straight
                    if (i < hand.Length - 1 && consec == true)
                    {
                        if (i < hand.Length - 2 && hand[i].rank != hand[i + 1].rank + 1)
                            consec = false;
                        //when on the last card in the hand, and the previous cards 
                        //were consecutive, it checks to see if the 4th card is a 5 and the
                        //final card is an ace.  In this case it would still be a straight 
                        //because the Ace would be counted as a low card instead of a high card                     
                        else if (i == hand.Length - 2)
                        {
                            if (hand[i].rank == RANK.Five && hand[i + 1].rank == RANK.Ace)
                                isStraight = hand[i].rank;
                            else if (hand[i].rank == hand[i + 1].rank + 1)
                                isStraight = hand[i + 1].rank;
                        }
                    }

                    //adding cards to dictionary so we know how many of each card
                    //are present in the hand
                    if (myHand.ContainsKey(hand[i].rank))
                        myHand[hand[i].rank]++;
                    else
                        myHand.Add(hand[i].rank, 1);
                }

                //Checking for hands with straights and flushes
                if (isFlush == true && isStraight == RANK.Ace)
                    return value = HAND_VALUE.Royal_Flush;
                else if (isFlush == true && isStraight != null)
                {
                    tiebreak = (int)isStraight;
                    return value = HAND_VALUE.Straight_Flush;
                }
                else if (isFlush)
                    return value = HAND_VALUE.Flush;
                else if (isStraight != null)
                {
                    tiebreak = (int)isStraight;
                    return value = HAND_VALUE.Straight;
                }

                //iterating through the dictionary to look for multiples
                foreach (KeyValuePair<RANK, int> kvp in myHand)
                {
                    if (kvp.Value == 4)
                        isQuad = kvp.Key;
                    else if (kvp.Value == 3)
                        isTrips = kvp.Key;
                    else if (kvp.Value == 2)
                    {
                        if (isPair == null)
                            isPair = kvp.Key;
                        else
                            isTwoPair = kvp.Key;
                    }
                }
                //checking for hands with multiples
                if (isQuad != null)
                {
                    tiebreak = (int)isQuad;
                    return value = HAND_VALUE.Four_of_a_Kind;
                }
                else if (isTrips != null)
                {
                    tiebreak = (int)isTrips;
                    if (isPair != null)
                        return value = HAND_VALUE.Full_House;
                    else
                        return value = HAND_VALUE.Three_of_a_Kind;
                }
                else if (isTwoPair != null)
                    return value = HAND_VALUE.Two_Pair;
                else if (isPair != null)
                    return value = HAND_VALUE.Pair;
                else
                    return value = HAND_VALUE.High_Card;
            }
            else
            {
                throw new ApplicationException("player does not have a complete hand");
            }
        }
    }
}

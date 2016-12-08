using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Test
    {
        //test Deck Class
        //create a test deck
        Deck testDeck = new Deck(5);
        Card testCard;

    
        //test printAllCards()
        public void testPrintAll(Deck deck)
        {
            int count = deck.getDeckCount();
            deck.printAllCards();
            Console.WriteLine("printAllCards method completed run...sucessful if " + count + " cards printed.");
        }

        //test dealCard()
        public Card testDealCard(Deck deck)
        {
            //testCard = new Card();
            Card dealtCard = deck.dealCard();
            Console.WriteLine(dealtCard);
            return dealtCard;

        }

        //test shuffle()



        //test printRemainingCards()

        //test getDeckCount()
    }
}

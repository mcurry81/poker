using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{

    class Program
    {

        //static Card[] deck = null;
        // static int dealIndex = 0;

        static void Main(string[] args)
        {

            
            Card testCardA;
            Card testCardB;

            //test creation of deck
            Console.WriteLine("Testing build of deck...");
            Console.WriteLine("run newDeck()...");
            Deck newDeck = new Deck();
            Console.WriteLine("There are " + newDeck.cardCount + " cards in the deck.");
            Console.WriteLine();

            //test printAllCards()
            Console.WriteLine("Testing PrintAllCards: ");
            Console.WriteLine("run printAllCards()...");
            newDeck.printAllCards();
            Console.WriteLine();

            //test dealCard()
            Console.WriteLine("Testing dealCard (pre-shuffle): ");
            Console.WriteLine("running dealCard()...");
            testCardA = newDeck.dealCard();
            Console.WriteLine("First Card dealt: " + testCardA._rank + " of " + testCardA._suit);
            Console.WriteLine("Testing dealCard, there are now " + newDeck.cardCount + " cards left in deck.");
            testCardB = newDeck.dealCard();
            Console.WriteLine("Second Card dealt: " + testCardB._rank + " of " + testCardB._suit);
            Console.WriteLine();


            //test printRemainingCards()
            Console.WriteLine("Testing printRemaining Cards: ");
            Console.WriteLine("running printRemainingCards()...");
            newDeck.printRemainingCards();
            Console.WriteLine();


            //test shuffle()
            Console.WriteLine("Testing shuffle: ");
            Console.WriteLine("running shuffle()...");
            newDeck.shuffle();
            Console.WriteLine("Deck after shuffle: ");
            Console.WriteLine("running printAllCards()...");
            newDeck.printRemainingCards();
            Console.WriteLine();



            //test getDeckCount()
            Console.WriteLine("Testing getDeckCount: ");
            newDeck.getDeckCount();
            Console.WriteLine();

            Console.WriteLine("Press any key to contiue..");
            Console.ReadKey();
        }
    } 
    
}

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

            Deck newDeck = new Deck();
            Test tester = new Test();

            //test printAllCards()
            tester.testPrintAll(newDeck);

            //test dealCard()

            //test shuffle()



            //test printRemainingCards()

            //test getDeckCount()
        }
    } 
}


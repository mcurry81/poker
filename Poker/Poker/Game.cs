using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Game
    {
        public Player player;
        public Deck currentDeck = new Deck();
        public Player house = new Player("House");
        protected int minCardsNeeded = 10;
        protected int numCardsToDeal = 5;

        public Game(Player player)
        {
            this.player = player;
            player.hand = new Card[numCardsToDeal];
            house.hand = new Card[numCardsToDeal];
        }

        //Begins a new game and returns the winner
        public Game PlayGame()
        {
            if (currentDeck.deckCount < minCardsNeeded)
            {
                currentDeck = new Poker.Deck();
            }
            for (int i = 0; i < numCardsToDeal; i++)
            {
                currentDeck.dealCard(player);
                currentDeck.dealCard(house);
            }
            if (house.hand.getValue() > player.hand.getValue())
                return house;
            else
                return player;
        }      
    }
}

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
        //Minimum number of cards needed to play a full round of the game
        protected int minCardsNeeded = 10;
        //Max number of cards allowed in the players cards
        protected int maxCardsInHand = 5;

        public Game(Player player)
        {
            this.player = player;
        }

        //Begins a new game and returns the winner
        public Player PlayGame()
        {
            player.hand = new Hand(maxCardsInHand);
            house.hand = new Hand(maxCardsInHand);
            if (currentDeck.getDeckCount() < minCardsNeeded)
            {
                currentDeck = new Poker.Deck();
            }
            for (int i = 0; i < maxCardsInHand; i++)
            {
                player.hand.addCard(currentDeck.dealCard());
                house.hand.addCard(currentDeck.dealCard());
            }
            if (house.hand.getValue() > player.hand.getValue())
                return house;
            else
                return player;
        }      
    }
}

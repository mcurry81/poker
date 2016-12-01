using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Player
    {
        public Card[] hand;
        public string name;
        int score = 0;

        public Player(string name)
        {
            this.name = name;
        }

        public int getScore()
        {
            return score;
        }

        public void setScore(int amountToAdd)
        {
            score += amountToAdd;
        }
    }
}

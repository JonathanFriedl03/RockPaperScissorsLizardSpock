using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        protected string name;
        protected int score;
        public List<Gesture>  gestures;
        public Player()
        {
            this.score = 0;
            gestures = new List<Gesture>()  { new Gesture("Rock"), new Gesture("Scissors"), new Gesture("Paper"), new Gesture("Lizard"), new Gesture("Spock") };
        }

    }
}

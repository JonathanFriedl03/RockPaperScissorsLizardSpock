using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public string name;
        public int score;
        public List<Gesture> gestures;
        public string gesture;
        public Player()
        {
            this.score = 0;
            
            gestures = new List<Gesture>() {new Gesture("Rock"), new Gesture("Scissors"), new Gesture("Paper"), new Gesture("Lizard"), new Gesture("Spock")};
        }
        public abstract void ChooseGesture();
        public void PrintGesture()
        {


            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine(i + ")" + gestures[i].move);
            }

            // ChooseGesture();

        }



    }
}

    


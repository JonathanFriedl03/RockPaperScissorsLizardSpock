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
        public List<string> gestures;
        public string gesture;
        public Player()
        {
            this.score = 0;
            
            gestures = new List<string>()  {"Rock", "Scissors","Paper", "Lizard", "Spock" };
        }
        public abstract void ChooseGesture();
        
           
        
    }
}

    


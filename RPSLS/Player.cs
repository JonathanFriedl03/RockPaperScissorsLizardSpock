using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
   abstract class Player
    {
        protected string name;
        protected int score;

        public Player()
        {
            this.score = 0;
            this.name = "";
        }
        public abstract void ChooseGesture();
       
    }
}

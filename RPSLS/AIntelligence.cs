using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AIntelligence : Player

    {
        Random rnd = new Random();
        public AIntelligence()
        {
            this.name = "Computer";
           
        }
        public override void ChooseGesture()
        {
            int rnd = this.rnd.Next(1, 5);
            gesture = gestures[rnd].move;
        }

    }
}

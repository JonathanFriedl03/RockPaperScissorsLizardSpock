using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {

        public Human(string name)
        {
            this.name = name;
        }


        public override void ChooseGesture()
        {
            
            
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine(gestures[i]);
            }
                   
            
            Console.WriteLine("Choose gesture");
            gesture = Console.ReadLine();

        }
    }
}

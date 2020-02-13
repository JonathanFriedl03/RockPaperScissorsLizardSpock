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
            Console.WriteLine("Choose gesture 0-4");
            var gesture = Console.ReadLine();
            try
            {
                if (int.Parse(gesture) <= 5 && int.Parse(gesture) >= 0)
                {
                    gesture = gestures[int.Parse(gesture) ].move;
                }
                else
                {
                    Console.WriteLine("Not a valid choice");
                    ChooseGesture();
                }
                
            }
            catch(FormatException)
            {
                Console.WriteLine("Not a valid choice");
                ChooseGesture();
            }
        


        }
    }
}

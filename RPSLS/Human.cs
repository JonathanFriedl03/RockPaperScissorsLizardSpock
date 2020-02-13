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

        public void PrintGesture()
        {
            
            
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine(i + ")" + gestures[i]);
            }
                          
            Console.WriteLine("Choose gesture");
            
        }
        
        public override void ChooseGesture()
        {
            PrintGesture();
            gesture = Console.ReadLine();
            try
            {
                if (int.Parse(gesture) <= 5 && int.Parse(gesture) > 0)
                {
                    gesture = gestures[int.Parse(gesture) - 1].move;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gameplay //need to establish players vs players
                  // "" call for user to determine whether or not there will be comp vs user or user vs user
                  //""compare turns and outcome of score and or user input 
                  //""simulate battle
    {
        AIntelligence aIntelligence;
        HumanOne playerOne;
        HumanTwo playerTwo;
        public Gameplay()
        {
            aIntelligence = new AIntelligence();
            playerOne = new HumanOne();
            playerTwo = new HumanTwo();
        }

        public void DisplayGameOptions(string userChoice)
        {
            Console.WriteLine("Please choose Player vs Player or Computer vs Player" );
            if (userChoice == "Player v Player")
            {

            }
        //    {
        //        for (int i = 0; i < fleet.robots.Count; i++)
        //        {
        //            Console.WriteLine(i + ") " + fleet.robots[i].name);
        //        }
        //    }
        //    else
        //    {
        //        for (int i = 0; i < herd.dinosaurs.Count; i++)
        //        {
        //            Console.WriteLine(i + ") " + herd.dinosaurs[i].name);
        //        }
        //    }
        }
    }
}

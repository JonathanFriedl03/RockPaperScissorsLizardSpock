using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// what i need
// where to write it
// how to write it

namespace RPSLS
{
    class GamePlay 
                    //Display Rules    
                    //need to establish players vs players
                  // "" call for user to determine whether or not there will be comp vs user or user vs user
                  //""compare turns and outcome of score and or user input 
                //method that increments player score  
                //""simulate battle
    {
        Player playerOne;
        Player playerTwo;
        

        public  GamePlay()
        {
           
        }
        public void SimulateGame()
        {
            DisplayGameRules();

            ChooseGameType();
            while(playerOne.score < 4 && playerTwo.score < 4)
            {
                playerOne.PrintGesture();

                playerOne.ChooseGesture();

                playerTwo.PrintGesture();

                playerTwo.ChooseGesture();

                CompareGesture();
            }
        }

        public void  DisplayGameRules()
        {
            Console.WriteLine("Welcome to Paper, Rock, Scissors, Lizard, Spock! \nIt's a variation of Paper, Scissors, Rock. Of which the Rules are the same.\nPaper beats Rock but also Spot. Scissors beats Paper and Lizard.\nRock beats Scissors and Lizard. Lizard beats Spock and paper.\nAnd Spock beats Scissors and Rock. \n The winner is determined by who wins the best of 3 rounds! \n Lets Begin!");
        }

        public void ChooseGameType()
        {
                        
            {
                Console.WriteLine("The game choices are Single Player or Player vs Player! \nPlease select key number 1 for Multiplayer or key number 2 for Single Player");
                var input = Console.ReadLine();                            
                Console.Clear();
                switch (input)
                {
                    case "1":
                    //case ConsoleKey.D1:
                        SetPlayers(1) ;
                        break;
                    case "2":
                    //case ConsoleKey.NumPad2:
                        SetPlayers(2) ;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number by pressing key number 1 or key number 2! Press enter to continue.");
                        ChooseGameType();
                        
                        break;
                }
            } 
        }

        public void SetPlayers(int number)
        {
            if(number == 1)
            {
                string newName = GetName();
                playerOne = new Human(newName);
                string newName2 = GetName();
                playerTwo = new Human(newName2);
            }
            else if(number == 2)
            {
                string newName = GetName();

                playerOne = new Human(newName);
                playerTwo = new AIntelligence();
            }
        }
        
        
        public string GetName()
        {
                Console.WriteLine("Player Please enter your name. Then press Enter");
                string newName = Console.ReadLine();
                return newName;
                
        }

        public void CompareGesture() 
        {
            
            if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("This round is a Tie! Lets try Again");
            }
            //rock beat scissors and lizard 1
            else if (playerOne.gesture == "Rock" && (playerTwo.gesture == "Scissors" || playerTwo.gesture == "Lizard")) 
            { Console.WriteLine($"{playerOne.gesture} beats {playerTwo.gesture}");
                playerOne.score++;
                Console.WriteLine($"{playerOne.name} score is { playerOne.score}. {playerOne.name} wins this round!");
            }//scissors beats paper & lizard 2
            else if (playerOne.gesture == "Scissors" && playerTwo.gesture == "Paper" || playerTwo.gesture == "Lizard")
            { Console.WriteLine($"{playerOne.gesture} beats {playerTwo.gesture}");
                playerOne.score++;
            }//Paper beats rock  & spot 3
            else if (playerOne.gesture == "Paper" && playerTwo.gesture == "Rock" || playerTwo.gesture == "Spot")
            { Console.WriteLine($"{playerOne.gesture} beats {playerTwo.gesture}");
                playerOne.score++;
            }//Lizard beats spock & paper 4
            else if (playerOne.gesture == "Lizard" && playerTwo.gesture == "Spock" || playerTwo.gesture == "Paper")
            { Console.WriteLine($"{playerOne.gesture} beats {playerTwo.gesture}");
                playerOne.score++;
            }//Spock beat scissors and rock 5
            else if (playerOne.gesture == "Spock" && playerTwo.gesture == "Scissors" || playerTwo.gesture == "Rock")
            {   Console.WriteLine($"{playerOne.gesture} beats {playerTwo.gesture}");
                playerOne.score++;
            } //rock beat scissors and lizard
            else if (playerTwo.gesture == "Rock" && playerOne.gesture == "Scissors" || playerOne.gesture == "Lizard")
            {
                Console.WriteLine($"{playerTwo.gesture} beats {playerOne.gesture}");
                playerTwo.score++;
            }//scissors beats paper & lizard
            else if (playerTwo.gesture == "Scissors" && playerOne.gesture == "Paper" || playerOne.gesture == "Lizard")
            {
                Console.WriteLine($"{playerTwo.gesture} beats {playerOne.gesture}");
                playerOne.score++;
            }//Paper beats rock  & spot
            else if (playerTwo.gesture == "Paper" && playerOne.gesture == "Rock" || playerOne.gesture == "Spot")
            {
                Console.WriteLine($"{playerTwo.gesture} beats {playerOne.gesture}");
                playerOne.score++;
            }//Lizard beats spock & paper
            else if (playerTwo.gesture == "Lizard" && playerOne.gesture == "Spock" || playerOne.gesture == "Paper")
            {
                Console.WriteLine($"{playerTwo.gesture} beats {playerOne.gesture}");
                playerTwo.score++;
            }//Spock beat scissors and rock
            else if (playerTwo.gesture == "Spock" && playerOne.gesture == "Scissors" || playerOne.gesture == "Rock")
            {
                Console.WriteLine($"{playerTwo.gesture} beats {playerOne.gesture}");
                playerTwo.score++;
            }

        }

         
      
        public void CheckForGameWinner()
        {
        }




    }
}

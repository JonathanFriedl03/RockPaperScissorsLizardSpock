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
            while(playerOne.score < 3 && playerTwo.score < 3)
            {
                playerOne.PrintGesture();

                playerOne.ChooseGesture();

                playerTwo.PrintGesture();

                playerTwo.ChooseGesture();

                CompareGesture();
                Console.Clear();

            }
            CheckForGameWinner();
        }

        public void  DisplayGameRules()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to Paper, Rock, Scissors, Lizard, Spock!");
            Console.WriteLine("\nIt's a variation of Paper, Scissors, Rock. Of which the Rules are the same with some slight additions!");
            Console.WriteLine("\nPaper beats Rock but also Spot.");
            Console.WriteLine("\nScissors beats Paper and Lizard.");
            Console.WriteLine("\nRock beats Scissors and Lizard."); Console.WriteLine("\nLizard beats Spock and paper."); Console.WriteLine("\nAnd Spock beats Scissors and Rock.");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n As in the original...THE WINNER IS DETERMINED by who wins the best of 3 rounds!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPress Enter to Begin!");
            Console.ReadLine();
            Console.Clear();
        }   

        public void ChooseGameType()
        {
                        
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("The game choices are Single Player or MultiPlayer!\n \nPlease select number 1 for Multiplayer or number 2 for Single Player");
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
                Console.Clear();
                string newName2 = GetName();
                playerTwo = new Human(newName2);
                Console.Clear();
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
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("This round is a Tie! Lets try Again");
                Console.ReadLine();
            }
            //rock beat scissors and lizard 1
            else if (playerOne.gesture == "Rock" && (playerTwo.gesture == "Scissors" || playerTwo.gesture == "Lizard"))
            {
                Console.WriteLine($"{playerOne.gesture} SMASHES {playerTwo.gesture}");
                playerOne.score++;
                Console.WriteLine($"{playerOne.name} score is { playerOne.score}. {playerOne.name} wins this round!");
                Console.ReadLine();
            }//scissors beats paper & lizard 2
            else if (playerOne.gesture == "Scissors" && (playerTwo.gesture == "Paper" || playerTwo.gesture == "Lizard"))
            { Console.WriteLine($"{playerOne.gesture} CUTS {playerTwo.gesture}");
                playerOne.score++;
                Console.WriteLine($"{playerOne.name} score is { playerOne.score}. {playerOne.name} wins this round!");
                Console.ReadLine();
            }//Paper beats rock  & spot 3
            else if (playerOne.gesture == "Paper" && (playerTwo.gesture == "Rock" || playerTwo.gesture == "Spot"))
            { Console.WriteLine($"{playerOne.gesture} COVERS {playerTwo.gesture}");
                playerOne.score++;
                Console.WriteLine($"{playerOne.name} score is { playerOne.score}. {playerOne.name} wins this round!");
                Console.ReadLine();
            }//Lizard beats spock & paper 4
            else if (playerOne.gesture == "Lizard" && (playerTwo.gesture == "Spock" || playerTwo.gesture == "Paper"))
            { Console.WriteLine($"{playerOne.gesture} EATS {playerTwo.gesture}");
                playerOne.score++;
                Console.WriteLine($"{playerOne.name} score is { playerOne.score}. {playerOne.name} wins this round!");
                Console.ReadLine();
            }//Spock beat scissors and rock 5
            else if (playerOne.gesture == "Spock" && (playerTwo.gesture == "Scissors" || playerTwo.gesture == "Rock"))
            {   Console.WriteLine($"{playerOne.gesture} OUTSMARTS {playerTwo.gesture}");
                playerOne.score++;
                Console.WriteLine($"{playerOne.name} score is { playerOne.score}. {playerOne.name} wins this round!");
                Console.ReadLine();
            } //rock beat scissors and lizard
            else if (playerTwo.gesture == "Rock" && (playerOne.gesture == "Scissors" || playerOne.gesture == "Lizard"))
            {
                Console.WriteLine($"{playerTwo.gesture} SMASHES {playerOne.gesture}");
                playerTwo.score++;
                Console.WriteLine($"{playerTwo.name} score is { playerTwo.score}. {playerTwo.name} wins this round!");
                Console.ReadLine();
            }//scissors beats paper & lizard
            else if (playerTwo.gesture == "Scissors" && (playerOne.gesture == "Paper" || playerOne.gesture == "Lizard"))
            {
                Console.WriteLine($"{playerTwo.gesture} CUTS {playerOne.gesture}");
                playerTwo.score++;
                Console.WriteLine($"{playerTwo.name} score is { playerTwo.score}. {playerTwo.name} wins this round!");
                Console.ReadLine();
            }//Paper beats rock  & spot
            else if (playerTwo.gesture == "Paper" && (playerOne.gesture == "Rock" || playerOne.gesture == "Spot"))
            {
                Console.WriteLine($"{playerTwo.gesture} COVERS {playerOne.gesture}");
                playerTwo.score++;
                Console.WriteLine($"{playerTwo.name} score is { playerTwo.score}. {playerTwo.name} wins this round!");
                Console.ReadLine();
            }//Lizard beats spock & paper
            else if (playerTwo.gesture == "Lizard" && (playerOne.gesture == "Spock" || playerOne.gesture == "Paper"))
            {
                Console.WriteLine($"{playerTwo.gesture} EATS {playerOne.gesture}");
                playerTwo.score++;
                Console.WriteLine($"{playerTwo.name} score is { playerTwo.score}. {playerTwo.name} wins this round!");
                Console.ReadLine();
            }//Spock beat scissors and rock
            else if (playerTwo.gesture == "Spock" && (playerOne.gesture == "Scissors" || playerOne.gesture == "Rock"))
            {
                Console.WriteLine($"{playerTwo.gesture} OUTSMARTS {playerOne.gesture}");
                playerTwo.score++;
                Console.WriteLine($"{playerTwo.name} score is { playerTwo.score}. {playerTwo.name} wins this round!");
                Console.ReadLine();
            }

        }

         
      
        public void CheckForGameWinner()
        {
            if(playerOne.score ==3)
            {
                Console.WriteLine(($"{ playerOne.name} Wins!"));
                Console.ReadLine();
            }
            else if (playerTwo.score == 3)
            {
                Console.WriteLine(($"{playerTwo.name} Wins!"));
                Console.ReadLine();
            }
        }




    }
}

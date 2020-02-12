﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }

        public void  DisplayGameRules()
        {
            Console.WriteLine("Welcome to Paper, Rock, Scissors, Lizard, Spock! \nIt's a variation of Paper, Scissors, Rock. Of which the Rules are the same.\nPaper beats Rock but also Spot. Scissors beats Paper and Lizard.\nRock beats Scissors and Lizard. Lizard beats Spock and paper.\nAnd Spock beats Scissors and Rock.");
        }

        public void ChoosePlayerType()
        {
            bool isValid = false;
            int numberOfWrong = 0;
            do
            {
                Console.WriteLine("The game choices are Single Player or Player vs Player! \nPlease select key number 1 for Multiplayer or key number 2 for Single Player");
                ConsoleKeyInfo input = Console.ReadKey();
                
                
                
                Console.Clear();

                switch (input.Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        SetPlayers(1) ;
                        isValid = true;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        SetPlayers(2) ;
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number by pressing key number 1 or key number 2! Press enter to continue.");
                        Console.ReadLine();
                        numberOfWrong++;
                        break;
                }
            } while (isValid == false && numberOfWrong < 3);
        }

        public void SetPlayers(int number)
        {
            if(number == 1)
            {
                string newName = Getmethod()
                playerOne = new Human(newName);
                playerTwo = new Human(newName);
            }
            else if(number == 2)
            {
                string newName = Getmethod()

                playerOne = new Human(newName);
                playerTwo = new AIntelligence();
            }
        }
        
        public void DisplayGesture()
        {
            for (int i = 0; i < playerOne.gestures.Count; i++)
                Console.WriteLine(i + " " + playerOne.gestures[0]);
        }
        public void Getmethod()
        {

        }
        public void ChooseGesture()
        {


        }
        public void CompareGesture()
        {
        }
        public void DetermineRoundWInner()
        {
        }
        public void IncrementScore()
        {
        }
        public void CheckIfGameWinner()
        {
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        public int score = 0;

        public Player()
        {
            
        }
        public int ConvertThrow(string userInput)
        {
            int playerThrow = 0;
            switch (userInput)
            {
                case "scissors":
                    playerThrow = 0;
                    break;
                case "paper":
                    playerThrow = 1;
                    break;
                case "rock":
                    playerThrow = 2;
                    break;
                case "lizard":
                    playerThrow = 3;
                    break;
                case "spock":
                    playerThrow = 4;
                    break;
                default:
                    Console.WriteLine("how did this happen?");
                    break;
                    
            }
            return playerThrow;
        }
        public virtual string GetThrow(string playerNumber)
        {
            Console.WriteLine("{0} enter throw", playerNumber);
            string userThrowInput = Console.ReadLine();
            while (userThrowInput != "scissors" && userThrowInput != "paper" && userThrowInput != "rock" && userThrowInput != "spock" && userThrowInput != "lizard")
            {
                Console.WriteLine("Please enter 'scissors', 'paper', 'rock', 'lizard', or 'spock'");
                userThrowInput = GetThrow(playerNumber);
            }
            return userThrowInput;
        }

    }
}


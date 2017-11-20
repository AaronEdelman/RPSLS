using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        public int score;

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
                    Console.WriteLine("Please input 'scissors', 'paper', 'rock', 'lizard', or 'spock'");
                    string userInput2 = Console.ReadLine();
                    playerThrow = ConvertThrow(userInput2);
                    break;
            }
            return playerThrow;
        }
        public virtual string GetThrow(string playerNumber)
        {
            Console.WriteLine("{0} enter throw", playerNumber);
            string userThrowInput = Console.ReadLine();
            return userThrowInput;
        }

    }
}


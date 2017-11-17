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
        public int ThrowHand()
        {
            int playerThrow;
            Console.WriteLine("Throw Player One");
            string userInput = Console.ReadLine();
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
                    ThrowHand();
                    break;
            }
            return playerThrow;
        }
    }
}

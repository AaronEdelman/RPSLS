using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        
        public void RunGame()
        {
            explainRules();
            playerOne = new HumanOpponent();
            SelectOpponent();
            ThrowHand();
            //asdf crown winner
        }
        void explainRules()
        {
            Console.WriteLine("Welcome to the world of Rock, Paper, Scissors, Lizard, Spock. You will be matched up against either a pal or the computer to see who has best mastered Earth's five basic elements. The victor will be the first to subdue their oponent three times.");
        }
        public void SelectOpponent()
        {
            Console.WriteLine("Please select if you would like to play against a 'human' or a 'bot'.");
            string userSelection = Console.ReadLine();
            GrabOpponent(userSelection);
        }
        public void GrabOpponent(string userSelection)
        {
            if(userSelection == "human")
            {
                playerTwo = new HumanOpponent();
            }
            else if(userSelection == "bot")
            {
                playerTwo = new ComputerOpponent();
            }
            else if(userSelection != "human" || userSelection != "bot")
            {
                Console.WriteLine("Please write either 'human' or 'bot'. ");
                SelectOpponent();
            }
        }
        public void ThrowHand()
        {
            while (playerOne.score < 3 || playerTwo.score < 3)
            {
                string userOneInput = playerOne.GetThrow("player One");
                int playerOneThrow = playerOne.ConvertThrow(userOneInput);
                string userTwoInput = playerTwo.GetThrow("player Two");
                int playerTwoThrow = playerOne.ConvertThrow(userTwoInput);
                AnnounceThrows(userOneInput, userTwoInput);
                int throwDifference = CalculateThrowWinner(playerOneThrow, playerTwoThrow);
                DeclareThrowWinner(throwDifference);
            }
            CrownChamp(playerOne.score, playerTwo.score);
        }
        public int CalculateThrowWinner(int playerOneThrow, int playerTwoThrow)
        {
            int difference = (5 + playerOneThrow - playerTwoThrow) % 5;
            return difference;
        }
        public void AnnounceThrows(string playerOneInput, string playerTwoInput)
        {
            Console.WriteLine("Player One threw a" + playerOneInput + ". Player Two threw a" + playerTwoInput + ".");
        }
        public void DeclareThrowWinner(int throwDifference)
        {
            if (throwDifference == 1 || throwDifference == 3)
            {
                playerOne.score++;
                Console.WriteLine("Player One wins this round.");
            }
            else if (throwDifference == 2 || throwDifference == 4)
            {
                playerTwo.score++;
                Console.WriteLine("Player Two wins this round");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }
        public void CrownChamp(int playerOneScore, int playerTwoScore)
        {
            if (playerOneScore == 3)
            {
                Console.WriteLine("Player One Wins");
            }
            else
            {
                Console.WriteLine("Player Two Wins");
            }
        }
    }
}      

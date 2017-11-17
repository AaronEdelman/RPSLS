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
            selectOpponent();
            //throw hand
            //crown winner
        }
        void explainRules()
        {
            Console.WriteLine("Welcome to the world of Rock, Paper, Scissors, Lizard, Spock. You will be matched up against either a pal or the computer to see who has best mastered Earth's five basic elements. The victor will be the first to subdue their oponent three times.");
        }
        public void selectOpponent()
        {
            Console.WriteLine("Please select if you would like to play against a 'human' or a 'bot'.");
            string userSelection = Console.ReadLine();
            grabOppoonent(userSelection);
        }
        public void grabOppoonent(string userSelection)
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
                selectOpponent();
            }
        }
    }
}

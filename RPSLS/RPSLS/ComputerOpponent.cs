using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ComputerOpponent:Player
    {
        public override string GetThrow(string playerNumber)
        {
            int compThrow = new Random().Next(0, 4);
            string compThrowString = ConvertCompNumber(compThrow);
            return compThrowString;
        }
        public string ConvertCompNumber(int compThrowNum)
        {
            string compThrowString = "";
            switch (compThrowNum)
            {
                case 0:
                    compThrowString = "scissors";
                    break;
                case 1:
                    compThrowString = "paper";
                    break;
                case 2:
                    compThrowString = "rock";
                    break;
                case 3:
                    compThrowString = "lizard";
                    break;
                case 4:
                    compThrowString = "spock";
                    break;
            }
            return compThrowString;
        }
    }
}

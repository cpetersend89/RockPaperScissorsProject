using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class results : prompts
    {
        public void gameResults(string result1, string result2, string playerOneName, string playerTwoName)
        {
            int playerOneScore = 0;
            int playerTwoScore = 0;

            if (result1 == result2)
            {
                tie(result1, result2, playerOneName, playerTwoName);
            }
            else if (result1 == "ROCK" && result2 == "SCISSORS" || result2 == "LIZARD")
            {
                playerOneWins(result1, result2, playerOneName, playerTwoName);
                playerOneScore++; 
            }
            else if (result1 == "PAPER" && result2 == "ROCK" || result2 == "SPOCK")
            {
                playerOneWins(result1, result2, playerOneName, playerTwoName);
                playerOneScore++;
            }
            else if (result1 == "SCISSORS" && result2 == "PAPER" || result2 == "LIZARD")
            {
                playerOneWins(result1, result2, playerOneName, playerTwoName);
                playerOneScore++;
            }
            else if (result1 == "LIZARD" && result2 == "PAPER" || result2 == "SPOCK")
            {
                playerOneWins(result1, result2, playerOneName, playerTwoName);
                playerOneScore++;
            }
            else if (result1 == "SPOCK" && result2 == "ROCK" || result2 == "SCISSORS")
            {
                playerOneWins(result1, result2, playerOneName, playerTwoName);
                playerOneScore++;
            }
            else
            {
                playerTwoWins(result1, result2, playerOneName, playerTwoName);
                playerTwoScore++;
            }

            string scores = "\n\nSCORES:\t" + playerOneName + ":\t" + playerOneScore + "\t" + playerTwoName + ":\t" + playerTwoScore;
            System.IO.File.WriteAllText(@"C:\Users\Christian Petersen\Documents\Visual Studio 2015\Projects\RockPaperScissors\test.txt", scores);
        }
    }
}

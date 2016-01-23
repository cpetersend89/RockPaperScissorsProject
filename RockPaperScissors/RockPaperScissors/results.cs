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

            if (result1 == "ROCK" && result2 == "PAPER")
            {
                playerTwoWins(result1, result2, playerOneName, playerTwoName);
                playerTwoScore++;
                
            }
            else if (result1 == "ROCK" && result2 == "SCISSORS")
            {
                playerOneWins(result1, result2, playerOneName, playerTwoName);
                playerOneScore++;
            }
            else if (result1 == "PAPER" && result2 == "ROCK")
            {
                playerOneWins(result1, result2, playerOneName, playerTwoName);
                playerOneScore++;
            }
            else if (result1 == "PAPER" && result2 == "SCISSORS")
            {
                playerTwoWins(result1, result2, playerOneName, playerTwoName);
                playerTwoScore++;
            }
            else if (result1 == "SCISSORS" && result2 == "ROCK")
            {
                playerTwoWins(result1, result2, playerOneName, playerTwoName);
                playerTwoScore++;
            }
            else if (result1 == "SCISSORS" && result2 == "PAPER")
            {
                playerOneWins(result1, result2, playerOneName, playerTwoName);
                playerOneScore++;
            }
            else
            {
                tie(result1, result2, playerOneName, playerTwoName);
            }

            keepScore(playerOneName, playerTwoName, playerOneScore, playerTwoScore);
        }
    }
}

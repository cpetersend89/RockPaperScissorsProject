using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class prompts
    {
        public void startGame()
        {
            Console.WriteLine("\n\nPress any key to start game:");
            Console.ReadKey();
            Console.Clear();
        }
        public void playerQuestions()
        {
            Console.WriteLine("Choose between ROCK, PAPER, SCISSORS, LIZARD, and SPOCK.");
        }
        public void playerOneWins(string result1, string result2, string playerOneName, string playerTwoName)
        {
            Console.WriteLine(playerOneName + " chose: " + result1 + "\n" + playerTwoName + " chose: " + result2 + "\n" + playerOneName + " WINS!");
        }

        public void playerTwoWins(string result1, string result2, string playerOneName, string playerTwoName)
        {
            Console.WriteLine(playerOneName + " chose: " + result1 + "\n" + playerTwoName + " chose: " + result2 + "\n" + playerTwoName + " WINS!");
        }

        public void tie(string result1, string result2, string playerOneName, string playerTwoName)
        {
            Console.WriteLine(playerOneName + " chose: " + result1 + "\n" + playerTwoName + " chose: " + result2 + "\n" + "IT'S A DRAW!");
        }

        public void keepScore(string playerOneName, string playerTwoName, int playerOneScore, int playerTwoScore)
        {
        Console.WriteLine("\n\nSCORES:\t" + playerOneName + ":\t{0}\t" + playerTwoName + ":\t{1}", playerOneScore++, playerTwoScore++);
        }
    }
}

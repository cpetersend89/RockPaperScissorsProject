using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class results
    {
        public void gameResults(string result1, string result2, string playerOneName, string playerTwoName)
        {
            if (result1 == "ROCK" && result2 == "ROCK")
            {
                Console.WriteLine(playerOneName + " chose: " + result1 + "\n" + playerTwoName + " chose: " + result2 + "\nIT'S A DRAW!");
                Console.ReadLine();
            }
            else if (result1 == "ROCK" && result2 == "PAPER")
            {
                Console.WriteLine(playerOneName + " chose: " + result1 + "\n" + playerTwoName + " chose: " + result2 + "\n" + playerTwoName + " WINS!");
                Console.ReadLine();
            }
            else if (result1.ToString() == "ROCK" && result2.ToString() == "SCISSORS")
            {
                Console.WriteLine(playerOneName + " chose: " + result1 + "\n" + playerTwoName + " chose: " + result2 + "\n" + playerOneName + " WINS!");
                Console.ReadLine();
            }
            else if (result1.ToString() == "PAPER" && result2.ToString() == "ROCK")
            {
                Console.WriteLine(playerOneName + " chose: " + result1 + "\n" + playerTwoName + " chose: " + result2 + "\n" + playerOneName + " WINS!");
                Console.ReadLine();
            }
            else if (result1.ToString() == "PAPER" && result2.ToString() == "PAPER")
            {
                Console.WriteLine(playerOneName + " chose: " + result1 + "\n" + playerTwoName + " chose: " + result2 + "\nIT'S A DRAW!");
                Console.ReadLine();
            }
            else if (result1.ToString() == "PAPER" && result2.ToString() == "SCISSORS")
            {
                Console.WriteLine(playerOneName + " chose: " + result1 + "\n" + playerTwoName + " chose: " + result2 + "\n" + playerTwoName + " WINS!");
                Console.ReadLine();
            }
            else if (result1.ToString() == "SCISSORS" && result2.ToString() == "ROCK")
            {
                Console.WriteLine(playerOneName + " chose: " + result1 + "\n" + playerTwoName + " chose: " + result2 + "\n" + playerTwoName + " WINS!");
                Console.ReadLine();
            }
            else if (result1.ToString() == "SCISSORS" && result2.ToString() == "PAPER")
            {
                Console.WriteLine(playerOneName + " chose: " + result1 + "\n" + playerTwoName + " chose: " + result2 + "\n" + playerOneName + " WINS!");
                Console.ReadLine();
            }
            else if (result1.ToString() == "SCISSORS" && result2.ToString() == "SCISSORS")
            {
                Console.WriteLine(playerOneName + " chose: " + result1 + "\n" + playerTwoName + " chose: " + result2 + "\nIT'S A DRAW!");
                Console.ReadLine();
            }
        }
    }
}

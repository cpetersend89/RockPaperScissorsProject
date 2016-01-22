using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {

        static void Main(string[] args)
        {
            multiPlayerOptions multiPlayerOptions = new multiPlayerOptions();
            int selectedPlayers = multiPlayerOptions.setPlayers();

            if (selectedPlayers == 2)
            {
                playerNames playerNames = new playerNames();
                string playerOneName = playerNames.playerOneName();
                string playerTwoName = playerNames.playerTwoName();

                playerOneTurn playerOneChoice = new playerOneTurn();
                string result1 = playerOneChoice.goPlayerOne(playerOneName);

                playerTwoTurn playerTwoChoice = new playerTwoTurn();
                string result2 = playerTwoChoice.goPlayerTwo(playerTwoName);

                results results = new results();
                results.gameResults(result1, result2, playerOneName, playerTwoName);
            }
            else
            {
                playerNames playerNames = new playerNames();
                string playerOneName = playerNames.playerOneName();
                string cpuName = playerNames.cpuName();

                playerOneTurn playerOneChoice = new playerOneTurn();
                string result1 = playerOneChoice.goPlayerOne(playerOneName);

                cpuChoice cpuChoice = new cpuChoice();
                string result2 = cpuChoice.randomChoice();

                results results = new results();
                results.gameResults(result1, result2, playerOneName, cpuName);
            }
        }
    }
}

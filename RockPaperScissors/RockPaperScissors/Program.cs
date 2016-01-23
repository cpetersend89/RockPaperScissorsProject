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
            bool playAgain = true;



                    multiPlayerOptions multiPlayerOptions = new multiPlayerOptions();
                    int selectedPlayers = multiPlayerOptions.setPlayers();

                if (selectedPlayers == 2)
                {
                    playerNames playerNames = new playerNames();
                    string playerOneName = playerNames.playerOneName();
                    string playerTwoName = playerNames.playerTwoName();

                    while (playAgain)
                    {
                    playerOneTurn playerOneChoice = new playerOneTurn();
                    string result1 = playerOneChoice.goPlayerOne(playerOneName);

                    playerTwoTurn playerTwoChoice = new playerTwoTurn();
                    string result2 = playerTwoChoice.goPlayerTwo(playerTwoName);

                    results results = new results();
                    results.gameResults(result1, result2, playerOneName, playerTwoName);

                    Console.WriteLine("Do you want to play again?(y/n)");
                    string loop = Console.ReadLine();
                    if (loop == "y")
                    {
                        playAgain = true;
                        
                    }
                    else if (loop == "n")
                    {
                        playAgain = false;
                    }
                    else
                    {

                    }

                }

                }
                else
                {
                    playerNames playerNames = new playerNames();
                    string playerOneName = playerNames.playerOneName();
                    string cpuName = playerNames.cpuName();

                    while (playAgain)
                    {
                    playerOneTurn playerOneChoice = new playerOneTurn();
                    string result1 = playerOneChoice.goPlayerOne(playerOneName);

                    cpuChoice cpuChoice = new cpuChoice();
                    string result2 = cpuChoice.randomChoice();

                    results results = new results();
                    results.gameResults(result1, result2, playerOneName, cpuName);

                    Console.WriteLine("Do you want to play again?(y/n)");
                    string loop = Console.ReadLine();
                    if (loop == "y")
                    {
                        playAgain = true;
                        Console.Clear();
                    }
                    else if (loop == "n")
                    {
                        playAgain = false;
                    }
                    else
                    {

                    }
                }
                }

        }
        }
    }


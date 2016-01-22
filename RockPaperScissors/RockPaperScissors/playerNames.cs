using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class playerNames : randomNumberGenerator
    {
        public string playerOneName()
        {
            string playerOne;
            Console.WriteLine("Player One, What is your name?");
            playerOne = Console.ReadLine().ToUpper();
            Console.Clear();
            return playerOne;
        }

        public string playerTwoName()
        {
            string playerTwo;
            Console.WriteLine("Player Two, What is your name?");
            playerTwo = Console.ReadLine().ToUpper();
            Console.Clear();
            return playerTwo;
        }

        public string cpuName()
        {
            string cpuName;
            cpuName = "COMPUTER";
            return cpuName;
        }
    }
}

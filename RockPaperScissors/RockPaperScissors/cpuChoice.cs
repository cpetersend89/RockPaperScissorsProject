using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class cpuChoice : randomNumberGenerator
    {
        public enum options
        {
            ROCK, PAPER, SCISSORS, LIZARD, SPOCK
        }
        public string randomChoice()
        {
            int randomChoice = calcRandomNumber();

            string[] cpuChoice = Enum.GetNames(typeof(options));

            var cpuOutput = Enum.Parse(typeof(options), cpuChoice[randomChoice]);

            return cpuOutput.ToString();
        }
    }
}
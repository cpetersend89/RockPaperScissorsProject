using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class cpuChoice : randomNumberGenerator
    {
        private enum options
        {
            ROCK, PAPER, SCISSORS
        }
        public string randomChoice()
        {
            string[] names = Enum.GetNames(typeof(options));

            Random random = new Random();

            int randomChoice = random.Next(names.Length);

            var cpuOutput = Enum.Parse(typeof(options), names[randomChoice]);

            return cpuOutput.ToString();
        }
    }
}


    /* int responseIndex = calcRandomNumber();
            string cpuOutput;

            switch (responseIndex)
            {
                case 1:
                    cpuOutput = "ROCK";
                    break;
                case 2:
                    cpuOutput = "PAPER";

                    break;
                case 3:
                    cpuOutput = "SCISSORS";
                    break;

            }
            return cpuOutput;
            }
             */
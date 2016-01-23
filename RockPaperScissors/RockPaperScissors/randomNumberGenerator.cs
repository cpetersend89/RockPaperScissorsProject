using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class randomNumberGenerator
    {
        public int calcRandomNumber ()
        {
            Random numberGenerator = new Random();
            int responseIndex = numberGenerator.Next(0, 5);
            return responseIndex;
        }
    }
}

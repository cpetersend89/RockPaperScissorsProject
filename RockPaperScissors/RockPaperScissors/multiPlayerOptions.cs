using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class multiPlayerOptions
    {
        public int setPlayers()
        {
            int multiChoice;
            Console.WriteLine("Please choose number of players:\nFor ONE PLAYER type '1' TWO PLAYERS type '2'");
            multiChoice = Int32.Parse(Console.ReadLine());
            Console.Clear();
            return multiChoice;
        }
    }
}

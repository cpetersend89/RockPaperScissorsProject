using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class playerOneTurn : prompts
    {
        public string goPlayerOne(string playerOneName)
        {
            string playerOneInput;
            Console.Write(playerOneName + " : ");
            playerQuestions();
            playerOneInput = Console.ReadLine().ToUpper();
            Console.Clear();
            return playerOneInput;
        }
    }
}

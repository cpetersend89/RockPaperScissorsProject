using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class playerTwoTurn : prompts
    {
        public string goPlayerTwo(string playerTwoName)
        {
            string playerTwoInput;
            Console.Write(playerTwoName + " : ");
            playerQuestions();
            playerTwoInput = Console.ReadLine().ToUpper();
            Console.Clear();
            return playerTwoInput;
        }
    }
}

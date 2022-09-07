using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public interface IRandomChoice
    {
        string GetRandomChoice();
    }

    public class RandomChoice : IRandomChoice
    {
        private readonly IRandomNumber _randomNumber;
        private readonly string[] gameChoice = {"paper", "scissors", "rock"};

        public RandomChoice(IRandomNumber randomNumber)
        {
            _randomNumber = randomNumber;
        }
        public string GetRandomChoice()
        {
            string randomComputerChoice = gameChoice[_randomNumber.GetRandomNumber(gameChoice.Length)];
            return randomComputerChoice;
        }
    }
}

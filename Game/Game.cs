using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Game
    {
        private readonly IUserInputService _userInputService;
        private readonly ICurrentRound _currentRound;
        private readonly IRandomChoice _randomChoice;
        private readonly IComparisor _comparisor;
        private readonly IShowWinner _showWinner;

        public Game(IUserInputService userInputService, ICurrentRound currentRound, IRandomChoice randomChoice, IComparisor comparisor, IShowWinner showWinner)
        {
            _userInputService = userInputService;
            _currentRound = currentRound;
            _randomChoice = randomChoice;
            _comparisor = comparisor;
            _showWinner = showWinner;
        }

        public void Start()
        {
            string userChoice;
            string randomComputerChoice;

            Console.WriteLine("Let's see who starts the game!");
            Console.WriteLine("ROCK PAPER SCISSORS GAME");

            do
            {
                Console.WriteLine("Round: " + _currentRound.GetCurrent());

                userChoice = _userInputService.GetUserInput();

                randomComputerChoice = _randomChoice.GetRandomChoice();

                Console.Write("Computer choice: ");
                Console.WriteLine(randomComputerChoice);



                _currentRound.Increment();

            } while (_comparisor.FindWinner(randomComputerChoice, userChoice) == Winner.Noone);

            _showWinner.GetShowWinner(randomComputerChoice, userChoice);

            Console.ReadLine();
        }
    }
}

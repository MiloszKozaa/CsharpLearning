using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal interface IMainGame
    {
        void StartMainGame();
    }

    internal class MainGame : IMainGame
    {

        private readonly IStarterGame _starterGame;
        private readonly IRandomNumber _randomNumber;
        private readonly IUserInputService _userInputService;
        private readonly ICurrentRound _currentRound;

        public MainGame(IStarterGame starterGame, IRandomNumber randomNumber, IUserInputService userInputService, ICurrentRound currentRound)
        {
            _starterGame = starterGame;
            _randomNumber = randomNumber;
            _userInputService = userInputService;
            _currentRound = currentRound;
        }

        public void StartMainGame()
        {
            int totalValue = 0;
            Winner winner = _starterGame.Start();
            int randomNumber;
            int userChoice;
            if (winner == Winner.User)
            {
                do
                {
                    Console.WriteLine("Round: " + _currentRound.GetCurrent());

                    userChoice = int.Parse(_userInputService.GetUserInput());

                    randomNumber = _randomNumber.GetRandomNumber(10) + 1;
                    Console.WriteLine(randomNumber + " comp");

                    totalValue += randomNumber + userChoice;

                    Console.WriteLine();
                    Console.WriteLine(totalValue + " total");

                    _currentRound.Increment();

                } while (totalValue < 100);
            }
            
            if (winner == Winner.Computer)
            {

            }

            

            Console.ReadLine();
        }
        
    }
}

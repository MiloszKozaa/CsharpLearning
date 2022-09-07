using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class MainGame
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
            
            //int userChoice = int.Parse(_userInputService.GetUserInput());

            do
            {
                int randomNumber = _randomNumber.GetRandomNumber(10) + 1;

                Console.WriteLine("Round: " + _currentRound.GetCurrent());


                totalValue += randomNumber;

                Console.WriteLine(randomNumber + " rand");
                Console.WriteLine(totalValue + " total");

                _currentRound.Increment();

            } while (totalValue < 100);

            Console.ReadLine();
        }
        
    }
}

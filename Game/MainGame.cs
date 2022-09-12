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
        private readonly ITotalValue _totalValue;
        private readonly ICheckUserInputService _checkUserInputService;

        public MainGame(IStarterGame starterGame, IRandomNumber randomNumber, IUserInputService userInputService, ICurrentRound currentRound, ITotalValue totalValue, ICheckUserInputService checkUserInputService)
        {
            _starterGame = starterGame;
            _randomNumber = randomNumber;
            _userInputService = userInputService;
            _currentRound = currentRound;
            _totalValue = totalValue;
            _checkUserInputService = checkUserInputService;
        }

        public void StartMainGame()
        {
            Winner winner = _starterGame.Start();
            int randomNumber;
            int userChoice;

            Console.WriteLine("This is a game in which you will win by getting the 100 number first.");
            Console.WriteLine("You can onlu chooce number between 1 and 10.");
            Console.WriteLine("Enjoy!");

            if (winner == Winner.User)
            {
                while (_totalValue.CheckTotalValue())
                {
                    Console.WriteLine("Round: " + _currentRound.GetCurrent());
                    Console.WriteLine();
                        
                    userChoice = _checkUserInputService.GetCheckedUserInputService(int.Parse(_userInputService.GetUserInput()));
                    randomNumber = _randomNumber.GetRandomNumber(10) + 1;
                    Console.WriteLine("AI choice: " + randomNumber);
                    _totalValue.UpdateTotalValue(userChoice, randomNumber);

                    Console.WriteLine();
                    Console.WriteLine("Total Value: " + _totalValue.GetTotalValue());
                    Console.WriteLine();

                    _currentRound.Increment();

                };
            }
            
            if (winner == Winner.Computer)
            {
                Console.WriteLine("Computer starts the game");
            }

            

            Console.ReadLine();
        }
        
    }
}

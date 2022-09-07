using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public interface IShowWinner
    {
        void GetShowWinner(string computerChoice, string userChoice);
    }
    public class ShowWinner : IShowWinner
    {
        private readonly IComparisor _comparisor;
        public ShowWinner(IComparisor comparisor)
        {
            _comparisor = comparisor;
        }
        public void GetShowWinner(string computerChoice, string userChoice)
        {

            Winner player = _comparisor.FindWinner(computerChoice, userChoice);
            
            if(player == Winner.Computer)
            {
                Console.WriteLine("Computer win! He's going to start a game.");
            }
            if (player == Winner.User)
            {
                Console.WriteLine("You win! You're going to start a game.");
            }
            if (player == Winner.Noone)
            {
                Console.WriteLine("Noone win the game.");
            }
        }
    }
}

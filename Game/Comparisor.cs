using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public enum Winner
    {
        Noone, 
        User, 
        Computer
    }
    public interface IComparisor
    {
        Winner FindWinner(string computer, string user);

    }
    public class Comparisor : IComparisor
    {
        public Winner FindWinner(string computer, string user)
        {
            if (computer == user)
            {
                return Winner.Noone;
            }
            if (computer == "paper" && user == "rock")
            {
                return Winner.Computer;
            }
            if (computer == "paper" && user == "scissors")
            {
                return Winner.User;
            }
            if (computer == "rock" && user == "scissors")
            {
                return Winner.Computer;
            }
            if (computer == "rock" && user == "paper")
            {
                return Winner.User;
            }
            if (computer == "scissors" && user == "paper")
            {
                return Winner.Computer;
            }
            if (computer == "scissors" && user == "rock")
            {
                return Winner.User;
            }

            throw new Exception();
        }
    }
}

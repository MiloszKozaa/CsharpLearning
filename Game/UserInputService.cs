using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public interface IUserInputService
    {
        string GetUserInput();
    }

    public class UserInputService : IUserInputService
    {
        public string GetUserInput()
        {
            Console.Write("Write your choice: ");
            string userChoice = Console.ReadLine();
            return userChoice;
        }
    }
}

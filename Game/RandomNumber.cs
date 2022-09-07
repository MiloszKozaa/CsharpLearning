using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public interface IRandomNumber
    {
        int GetRandomNumber(int maxElement);
    }
    public class RandomNumber : IRandomNumber
    {
        public int GetRandomNumber(int maxElement)
        {

            Random random = new Random();
            int randomComputerChoiceNumber = random.Next(maxElement);
            return randomComputerChoiceNumber;
        }
    }

    public class RandomNumberMocked : IRandomNumber
    {
        public int GetRandomNumber(int maxElement)
        {
            return 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class ComputerChoice
    {
        private readonly ITotalValue _totalValue;
        public ComputerChoice(ITotalValue totalValue)
        {
            _totalValue = totalValue;
        }   

        public int ComputerWinnerChoice(int value)
        {
            if(value > 89)
            {
                value = 100 - _totalValue.GetTotalValue();
                return value;
            } else
            {
                return value;
            }

        }
    }
}

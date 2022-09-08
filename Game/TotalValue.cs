using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface ITotalValue
    {
        int GetTotalValue();
        int UpdateTotalValue(int user, int computer);
    }
    internal class TotalValue : ITotalValue
    {
        private int totalValue;

        public TotalValue()
        {
            totalValue = 0;
        }   

        public int GetTotalValue()
        {
            return totalValue;
        }

        public int UpdateTotalValue(int user, int computer)
        {
            totalValue += user + computer;
            return totalValue;
        }
    }
}

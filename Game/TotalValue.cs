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
        bool CheckTotalValue();
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

        public bool CheckTotalValue()
        {
            bool highestNumber;

            if (totalValue == 100)
            {
                highestNumber = true;
                return highestNumber;
            }
            if (totalValue > 100)
            {
                Console.WriteLine("tooHighNumber");
                highestNumber = false;
                return highestNumber;
            }
            throw new Exception();
        }
    }
}

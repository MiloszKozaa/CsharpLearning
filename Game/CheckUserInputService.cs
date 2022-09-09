using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface ICheckUserInputService
    {
        int GetCheckedUserInputService(int checkedNumber);
    }
    
    internal class CheckUserInputService : ICheckUserInputService
    {
        public int GetCheckedUserInputService(int checkedNumber)
        {
            if(checkedNumber <= 10 && checkedNumber >= 1)
            {
                return checkedNumber;
            }

            throw new Exception();
        }
    }
}

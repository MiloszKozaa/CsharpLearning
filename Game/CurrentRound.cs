using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public interface ICurrentRound
    {
        void Increment();
        int GetCurrent();
    }

    public class CurrentRound : ICurrentRound
    {
        private int current;

        public CurrentRound()
        {
            current = 1;
        }
        public int GetCurrent()
        {
            return current;
        }

        public void Increment()
        {
            current++;
        }
    }
}

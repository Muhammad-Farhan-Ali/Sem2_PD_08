using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class BlackJackHand:Hand
    {
        public int getBlackJackValue()
        {
            int value = 0;
            for(int i = 0;i<hand.Count;i++)
            {
                value += hand[i].getValue();
            }
            return value;
        }

        public bool shouldDraw()
        {
            return getBlackJackValue() < 17;
        }
    }
}

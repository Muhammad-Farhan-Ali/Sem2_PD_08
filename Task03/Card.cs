using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task03
{
    class Card
    {
        private int value;
        private int suit;
        private int oneAce=0;
        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }
        public int getValue()
        {
            if(value>=10)
            {
                value = 10;
            }
            if(value==1 && oneAce==1)
            {
                value = 11;
                oneAce = 0;
            }
            return value;
        }
        public int getSuit()
        {
            return suit;
        }
        public string getValueAsString()
        {
            if (value == 1)
            {
                return "Ace";
            }
            else if (value == 11)
            {
                return "Jack";
            }
            else if (value == 12)
            {
                return "Queen";
            }
            else if (value == 13)
            {
                return "King";
            }
            else
            {
                return value.ToString();
            }
        }
        public string getSuitAsString()
        {
            if (suit == 1)
            {
                return "Clubs";
            }
            else if (suit == 2)
            {
                return "Diamonds";
            }
            else if (suit == 3)
            {
                return "Spades";
            }
            else
            {
                return "Hearts";
            }
        }
        public override string ToString()
        {
            return getValueAsString() + " of " + getSuitAsString();
        }
    }
}

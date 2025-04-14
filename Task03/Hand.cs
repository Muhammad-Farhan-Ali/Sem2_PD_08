using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class Hand
    {
        protected List<Card> hand = new List<Card>();
        
        public void clearHand()
        {
            hand.Clear();
        }

        public Card getCard(int position)
        {
            if(position <= 0 || position > hand.Count)
            {
                return null;
            }
            position -= 1;
            return hand[position];
        }

        public void addCard(Card card)
        {
            hand.Add(card);
        }
        
        public void removeCard(Card card)
        {
            hand.Remove(card);
        }
        public void removeCard(int position)
        {
            hand.RemoveAt(position);
        }
        public int getCardCount()
        {
            return hand.Count;
        }
        public void sortBySuit()
        {
            for(int i=0; i<hand.Count; i++)
            {
                for(int j=0;j<i-1;j++)
                {
                    Card card = hand[j];
                    if (card.getSuit() > hand[j+1].getSuit())
                    {
                        Card temp = hand[j];
                        hand[j] = hand[j+1];
                        hand[j+1] = temp;
                    }
                }
            }
        }
        public void sortByValue()
        {
            for (int i = 0; i < hand.Count; i++)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    Card card = hand[j];
                    if (card.getValue() > hand[j + 1].getValue())
                    {
                        Card temp = hand[j];
                        hand[j] = hand[j + 1];
                        hand[j + 1] = temp;
                    }
                }
            }
        }

        public void showHand(string name)
        {
            Console.WriteLine(name);
            foreach(Card card in hand)
            {
                Console.WriteLine(card.ToString());
            }
        }
    }
}

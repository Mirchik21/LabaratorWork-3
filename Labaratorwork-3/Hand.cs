using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorwork_3
{
    internal class Hand
    {
        Card[] cards = new Card[5];
        
        public void TakeCard(Card card)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == null)
                {
                    cards[i] = card;
                    break;
                }
            }
        }

        public Card[] Cards
        {
            get { return cards; }
        }
         
        public void PrintHand()
        {
            Console.Write("  ");
            for(int i = 1; i < 6; i++)
            {
                Console.Write(i);
                Console.Write("   | ");
            }
            Console.WriteLine();
            Console.Write("  ");
            for (int i = 0; i < 5; i++)
            {
                cards[i].PrintSelf();
                string spaces = " ";
                if (cards[i].ToString().Length == 2)
                {
                    spaces += " ";
                }
                Console.Write(spaces + "| ");
            }
        }

        public void ChangeCard(int card_index, Card card)
        {
            cards[card_index - 1] = card;
        }

    }

}

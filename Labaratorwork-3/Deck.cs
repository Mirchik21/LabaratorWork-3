using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorwork_3
{
    internal class Deck
    {
        Card[] cards = new Card[52];
        int retired_cards_counter;

        public Deck()
        {
            retired_cards_counter=0;
            string[] Ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string[] RedSuits = {"\u2665", "\u2666"};
            string[] BlackSuits = { "\u2660", "\u2663" };
            byte i = 0;
            foreach (string s in RedSuits)
            {
                foreach (string r in Ranks)
                {
                    RedCard c = new RedCard(r, s);
                    cards[i] = c; 
                    i++;
                }
            }
            foreach (string s in BlackSuits)
            {
                foreach (string r in Ranks)
                {
                    BlackCard c = new BlackCard(r, s);
                    cards[i] = c;
                    i++;
                }
            }
        }

        public Card[] Cards
        {
            get { return cards; }
        }

        public void Mix()
        {
            Random rand = new Random();
            
            for (int i = 0; i < cards.Length; i++)
            {
                int rand_number = rand.Next(0, 52);
                Card temp = cards[i];
                cards[i] = cards[rand_number]; 
                cards[rand_number] = temp;
            }
        }

        public void PrintCards()
        {
            foreach (Card card in this.Cards)
            {   
                card.PrintSelf();
                Console.Write(" ");
            }
        }

        public Card DrawCard()

        {
            Card c;
            if (retired_cards_counter > 51)
            {
                Mix();
                retired_cards_counter = 0;
                c = cards[retired_cards_counter];
            }
        else
            {
                c = cards[retired_cards_counter];
            }
            retired_cards_counter++;
            return c;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorwork_3
{
    internal class Card
    {
        string rank;
        string suit;

        public Card(string rank, string suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public override string ToString()
        {
            return rank + suit;
        }

        public virtual void PrintSelf()
        {
            Console.Write(this);
        }
    }
}

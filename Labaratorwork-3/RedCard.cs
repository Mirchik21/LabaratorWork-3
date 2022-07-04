using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorwork_3
{
    internal class RedCard : Card
    {
        public RedCard(string rank, string suit) : base(rank, suit) { }
        public override void PrintSelf()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(this);
            Console.ResetColor();
            
        }
    }
}

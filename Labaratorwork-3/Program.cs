namespace Labaratorwork_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            deck1.Mix();
            deck1.PrintCards();
            
            Hand hand1 = new Hand();
            for (int i = 0; i < 5; i++)
            hand1.TakeCard(deck1.DrawCard());
          
            Console.WriteLine("\n=========================");
            hand1.PrintHand();
            Console.WriteLine("\n=========================");

            Console.WriteLine("Enter the card numbers you want to replace with a space");
            Console.WriteLine("For example, /1 3 4/ , will replace 1, 3 and 4 cards respectively");

            string cardIndexes = Console.ReadLine();
            string[] cardIndArray = cardIndexes.Split(" ");

            foreach (string ind in cardIndArray)
            {
                Card card = deck1.DrawCard();
                hand1.ChangeCard(Int32.Parse(ind), card);
            }
            hand1.PrintHand();
        }      
    }        
}

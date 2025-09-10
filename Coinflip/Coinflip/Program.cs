namespace Coinflip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coinflip app");
            Random random = new Random();
            char redo;
            do
            { 
                int coin = random.Next(1,3);
                if(coin == 1)
                {
                    Console.WriteLine($"\nYour result is: HEADS");
                }
                else if(coin == 2)
                {
                    Console.WriteLine("\nYour result is: TAILS");
                }
                //Console.WriteLine($"Your result is: ");
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

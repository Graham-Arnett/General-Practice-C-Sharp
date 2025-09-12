namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice Game app");
            Random random = new Random();
            char redo;
            do
            {
                int roll = random.Next(1, 7);
                int[] r = new int[2];
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

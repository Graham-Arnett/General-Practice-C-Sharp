namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice Game app");
            Random random = new Random();
            char redo;
            int roll;
            do
            {
                
                int[] r = new int[2];
                roll = random.Next(1, 7);
                for (int i = 0; i < 2; i++)
                {
                    
                    roll = r[i];
                }
                Console.WriteLine($"You got {r[0]} for your first roll and {r[1]} for your second roll!");
                if (r[0] == r[1])
                {
                    Console.WriteLine("Ewwww you got doubles that's GROSS");
                }
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

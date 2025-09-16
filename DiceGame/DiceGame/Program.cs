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
                
                int[] r = new int[2];
                int totalRoll = 2;
                for (int i = 0; i < totalRoll; i++)
                {
                    
                    int roll;
                    roll = random.Next(1,7);
                    r[i] = roll;
                }
                Console.WriteLine($"\n\nYou got {r[0]} for your first roll and {r[1]} for your second roll!");
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

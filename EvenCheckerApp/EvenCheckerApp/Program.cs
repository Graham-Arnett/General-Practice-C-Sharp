namespace EvenCheckerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even number checker!");
            char redo;
            do
            {
                Console.Write("\n\nEnter a number: ");
                int entry = int.Parse(Console.ReadLine());
                if (entry % 2 == 0)
                {
                    Console.WriteLine("That is even!");
                }
                else
                {
                    Console.WriteLine("That is odd!");
                }
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

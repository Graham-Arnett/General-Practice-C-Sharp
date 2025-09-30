namespace TriangleDraw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle Drawing App");
            char redo;

            do
            {
                Console.Write("\n\nEnter a number: ");
                int entry = int.Parse(Console.ReadLine());
                for(int i = 1; i <= entry; i++)
                {
                    for(int j = 1; j <= i; j++)
                    {
                        Console.Write("");
                    }
                    for(int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

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
                for(int i = 0; i < 10; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

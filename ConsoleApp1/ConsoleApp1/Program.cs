namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Travel Time App!");
            char redo;
            do
            {
                Console.Write("Please enter a distance here in miles: ");
                double miles = double.Parse(Console.ReadLine());
                Console.Write("");
                Console.Write("\n\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

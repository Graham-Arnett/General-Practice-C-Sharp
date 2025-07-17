namespace midPointApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Midpoint Calculator app, again");
            char redo;
            double[] n = new double[4];
            do
            {
                for(int i = 0;i < 4; i++)
                {
                    Console.Write("\nEnter a number: ");
                    n[i] = double.Parse(Console.ReadLine());
                }
                double xpoint = (n[0] + n[1])/2;
                double ypoint = (n[2] - n[3])/2;
                Console.WriteLine($"Your midpoint is ({xpoint} , {ypoint})");
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

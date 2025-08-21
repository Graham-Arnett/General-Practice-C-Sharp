namespace QuadraticFormulaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the quadratic formula app");
            char redo;
            double[] n = new double[3];
            string[] order = {"FIRST","SECOND","THIRD"};
            do
            {
                for (int i = 0;i < 0; i++)
                {
                    Console.WriteLine($"\n\nPlease enter your {order[i]} number: ");
                    n[i] = double.Parse(Console.ReadLine());
                }

                Console.Write("\n\nWould you like to go again?(y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'Y' || redo == 'y');
        }
    }
}

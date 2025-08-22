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
                for (int i = 0;i < 3; i++)
                {
                    Console.Write($"\n\nPlease enter your {order[i]} number: ");
                    n[i] = double.Parse(Console.ReadLine());
                }
                double squaredPart = Math.Sqrt(((n[1] * n[1]) - 4*(n[0] * n[2])));
                double posVer = (-n[1] + squaredPart) / (2 * n[0]);
                double negVer = (n[1] - squaredPart) / (2 * n[0]);
                Console.WriteLine($"The solutions are: {posVer} , {negVer}");
                Console.Write("\n\nWould you like to go again?(y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'Y' || redo == 'y');
        }
    }
}

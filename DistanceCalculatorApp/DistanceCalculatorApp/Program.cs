namespace DistanceCalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Distance Calculator");
            char redo;
            double[] n = new double[4];
            do
            {
                for(int i = 0;i < 4; i++)
                {
                    Console.WriteLine("Enter a number: ");
                    n[i] = double.Parse(Console.ReadLine());
                }
                double distance = Math.Sqrt(Math.Abs((n[0] - n[1])* (n[0] - n[1]) + (n[2] - n[3])* (n[2] - n[3])));
                Console.Write($"Your distance is: {distance}\n" +
                    $"Would you like to go again? (y/n): ");
                redo =Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

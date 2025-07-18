namespace AreaPerimeterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area Perimeter Calculator");

            char redo;
            double[] n = new double[2];
            do
            {
                for(int i = 0;i < 2; i++)
                {
                    Console.Write("\nEnter a number: ");
                    n[i] = double.Parse(Console.ReadLine());
                }
                double perimeter = n[1] + n[0] + n[1] + n[0];
                double area = n[0] + n[1];
                Console.Write($"\n\nYour area is: {area} and your perimeter is: {perimeter}" +
                    $"\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

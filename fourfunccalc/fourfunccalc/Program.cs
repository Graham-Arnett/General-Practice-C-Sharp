namespace fourfunccalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Four function calculator app");
           
            double[] n = new double[2];//I like more descriptive names, but this is less clumsy just know n means number
            string[] p = {"first", "second"};//p means prompt
            char redo;
            do
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"\n\nPlease enter your {p[i]} number: ");
                    n[i] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Would you like to ADD, SUBTRACT, DIVIDE, or MULTIPLY");
                string functionPick = Console.ReadLine().ToUpper();
                double result;
                switch (functionPick)
                {
                    case "ADD":
                            result = n[0] + n[1];
                        Console.WriteLine($"Your sum is: {result}");
                        break;

                    case "SUBTRACT":
                        result = n[0] - n[1];
                        Console.WriteLine($"Your difference is: {result}");
                        break;

                    case "DIVIDE":
                        result = n[0] / n[1];
                        Console.WriteLine($"Your quotient is: {result}");
                        break;

                    case "MULTIPLY":
                        result = n[0] * n[1];
                        Console.WriteLine($"Your product is: {result}");
                        break;
                }
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

namespace fizzbuzzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz");
            char redo;
            char[] acceptChar = { 'y', 'Y', 'n', 'N' };
            do
            {
                Console.Write("\n\nPlease enter a number: ");
                int num = int.Parse(Console.ReadLine());
                if(num % 5 == 0 && num % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("FIZZBUZZ");
                }
                else if(num % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("FIZZ");
                }
                else if (num % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("BUZZ");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
                do
                {
                    //its gonna go back through it until valid, then the bool will be checked at the end
                    Console.Write("\n\nWould you like to go again? (y/n): ");
                    redo = Console.ReadKey().KeyChar;
                } while(true);
            }while(redo == 'y'||redo=='Y');
            //to do, add validation and stuff, idk I'm tired
        }
    }
}

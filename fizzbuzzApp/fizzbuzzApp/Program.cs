namespace fizzbuzzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz");
            char redo;
            bool gameEnd = false;
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
                else
                {
                    Console.WriteLine("Neither fizz nor buzz");
                }
                Console.ForegroundColor = ConsoleColor.White;
                //Console.Write("\n\nWould you like to go again? (y/n): ");
                //redo = Console.ReadKey().KeyChar;
                bool answered = false;
                do
                {
                    //its gonna go back through it until valid, then the bool will be checked at the end
                    //I see the error, its printing the would you like to go again message an extra time when it should not
                    Console.Write("\n\nWould you like to go again? (y/n): ");
                    redo = Console.ReadKey().KeyChar;
                    if (acceptChar.Contains(redo))
                    {
                        answered = true;
                        if (redo == 'n' || redo == 'N')
                        {
                            Console.WriteLine("\n\nThanks for playing!");
                            gameEnd = true;
                            
                        }
                        else if (redo == 'y' || redo == 'Y')
                        {
                            Console.WriteLine("\n\nLets play again!");
                            gameEnd = false;
                            
                        }

                    }
                    else
                    {
                        Console.WriteLine("\n\nThat is not valid, go again.");
                    }
                } while(answered == false);
            }while(gameEnd == false);
            //to do, add validation and stuff, idk I'm tired
        }
    }
}

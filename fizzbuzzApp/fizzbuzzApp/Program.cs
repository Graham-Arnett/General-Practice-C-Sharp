namespace fizzbuzzApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz");
            char redo;
            do
            {
                Console.Write("Please enter a number: ");
                int num = int.Parse(Console.ReadLine());
                if(num % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            }while(redo == 'y'||redo=='Y');
        }
    }
}

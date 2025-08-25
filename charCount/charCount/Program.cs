namespace charCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Character Counting App");
            char redo;
            do
            {
                int charCount = 0;
                Console.Write("\n\nWould you please enter some text: ");
                string word = Console.ReadLine();
                for(int i = 0; i < word.Length; i++)
                {
                    charCount++;
                }
                Console.WriteLine($"Your character count is: {charCount} characters!");
                Console.Write("\n\n\nWould you like to go again? (y/n:) ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'Y' || redo == 'y');
        }
    }
}

using System.ComponentModel.Design;

namespace WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word counting app");
            char redo;
            do
            {
                int wordCount = 0;
                Console.Write("\n\n\nPlease enter some text: ");
                string words = Console.ReadLine();
                for(int i = 0;i < words.Length; i++)
                {
                    if(words[i] == ' ')
                    {
                        wordCount++;
                    }
                    else
                    {

                    }
                    if (words[words.Length] != ' ')
                    {
                        words += ' ';
                        Console.WriteLine(words);
                    }
                }
                Console.Write("\n\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

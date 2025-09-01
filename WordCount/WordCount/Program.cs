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
                //ok
                int spaceCount = 0;
                Console.Write("\n\n\nPlease enter some text: ");
                string words = Console.ReadLine();
                for(int i = words.Length - 1;i >= 0; i--)
                {
                    if(words[i] == ' ')
                    {
                        spaceCount++;
                    }
                    else
                    {

                    }
                    
                   
                }
                if (!words.Contains(' '))
                {
                    spaceCount += 1;
                }
                Console.WriteLine($"Wordcount is: {spaceCount}");
                Console.Write("\n\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

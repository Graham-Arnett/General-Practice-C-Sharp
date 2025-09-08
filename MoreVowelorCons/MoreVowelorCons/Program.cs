namespace MoreVowelorCons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("More vowels or consonants app" +
                "\nThis is kinda dumb it just measures if a string you said has more consonants or vowels");
            char redo;
            char[] c = {'q','w','r','t','y','p','s','d','f','g','h','j','k','l','z','x','c','v','b','n','m'};
            char[] v = {'a','e','i','o','u'};
            char[] n = {'1','2','3','4','5','6','7','8','9','0'};
            char[] s = {'!','@','#','$','%','^','&','*','(',')','-','_','~','`','=','+','{','[',']','}'
            ,'/','|',':',';','"','<',',','.','>','?'};
            do
            {
                int vowelCount = 0;
                int consCount = 0;
                int numCount = 0;
                int specCount = 0;
                int spaceCount = 0;
                Console.Write("\n\nEnter some text: ");
                string text = Console.ReadLine();
                for (int i = text.Length -1; i >= 0; i--)
                {
                    if (c.Contains(text[i]))
                    {
                        consCount++;
                    }
                    else if (v.Contains(text[i]))
                    {
                        vowelCount++;
                    }
                    else if (n.Contains(text[i]))
                    {
                        numCount++;
                    }
                    else if (s.Contains(text[i]))
                    {
                        specCount++;
                    }
                    else if (text[i] == ' ')
                    {
                        spaceCount++;
                    }
                }
                if(vowelCount > consCount)
                {
                    Console.WriteLine("You had more vowels.\n");
                }
                else if(consCount == vowelCount)
                {
                    Console.WriteLine("They are equal.\n");
                }
                else
                {
                    Console.WriteLine("You had more consonants.\n");
                }
                Console.WriteLine($"You had {consCount} consonants and {vowelCount} vowels!" +
                    $"\nMuch less importantly, you had {numCount} numbers, {specCount} special characters and {spaceCount} spaces.");
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

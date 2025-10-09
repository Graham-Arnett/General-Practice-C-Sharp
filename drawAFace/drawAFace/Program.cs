namespace drawAFace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facedraw app! This will use user input fromp prompts to combine strings to make an ascii face");
            char redo;
            Random random = new Random();
            do
            {
                Console.Write("Would you like to design your face or let it randomize? (d or r): ");
                char initChoice = Console.ReadKey().KeyChar;
                string[] top =    {"///////////", "----------",   "___________",  "===========","77777777777"};
                string[] middle = {"| O     O |", "| ^  7  ^ |",  "| :     : |",  "| 0  0  0 |","( U      U )" };
                string[] bottom = { };
                if(initChoice == 'r')
                {
                    for (int i = 0; i < 3; i++)
                    {
                        //will roll 3 times for the top, middle, and bottom of the face)
                    }
                }
                Console.Write("\n\nWould you like to continue? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

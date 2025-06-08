namespace ttrpgRollerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Random Random = new Random();
            Roller.Stats();
            Roller.Classes();
            Roller.Backstory();
            Roller.Races();
        }
    }
    public class Roller
    {
        //Random Random = new Random();
        public static void Stats()
        {
            //int score = random.Next(1,7);
            Random random = new Random();
            int[] scoreArray = [6];
            int classPick = random.Next(1,5);
            int racePick = random.Next(1,5);
            int backPick = random.Next(1,5);

            for(int i = 0; i <1; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    int roll = random.Next(1,7);
                    scoreArray[i] += roll;

                }
            }
            Console.WriteLine($"Your strength is: {scoreArray}");
        }
        public static void Classes(int classPick)
        {

        }
        public static void Backstory()
        {

        }
        public static void Races()
        {

        }
    }
}

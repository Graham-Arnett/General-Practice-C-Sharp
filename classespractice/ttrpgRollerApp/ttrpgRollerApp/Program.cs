namespace ttrpgRollerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Random Random = new Random();
            Roller.Stats();
            Roller.Classes();
            Roller.Backstory();
            Roller.Races();
        }
    }
    public class Roller
    {
        //Random Random = new Random();
        public static void Stats(Random random)
        {
            //int score = random.Next(1,7);
            int[] scoreArray = [6];

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
        public static void Classes(Random random)
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

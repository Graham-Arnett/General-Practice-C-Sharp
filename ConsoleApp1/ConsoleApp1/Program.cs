namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Travel Time App!");
            char redo;
            //this takes your input for miles and speed as doubles, and returns the time it would take you to go that distance
            do
            {
                Console.Write("\nPlease enter a distance here in miles: ");
                double miles = double.Parse(Console.ReadLine());
                Console.Write("\nEnter a speed in miles per hour: ");
                double speed = double.Parse(Console.ReadLine());
                
                double hour = miles / speed;
                int wholeHour = (int)hour;

                int minutes = (int) ((hour -  wholeHour) * 60);
                Console.WriteLine($"\n\nAt a speed of {speed} miles per hour, it would take you {wholeHour} hours and {minutes} minutes to go {miles} miles.");
                Console.Write("\n\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}

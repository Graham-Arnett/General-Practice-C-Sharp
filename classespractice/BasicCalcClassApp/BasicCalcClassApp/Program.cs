namespace BasicCalcClassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            char redo;

            Messages.Hello();
            do
            {
                Messages.Question();
                string choice = Console.ReadLine().ToUpper();
                switch (choice)
                {
                    case "ADD":
                        Messages.InputPrompt();
                        num1 = double.Parse(Console.ReadLine());
                        Messages.InputPrompt();//ik ik this violates DRY, I'm still learning
                        num2 = double.Parse(Console.ReadLine());
                        Calculator.Add(num1, num2);
                        Console.WriteLine("Your sum is: " + Calculator.Add(num1,num2));
                        break;
                    case "SUBTRACT":
                        Messages.InputPrompt();
                        num1 = double.Parse(Console.ReadLine());
                        Messages.InputPrompt();//ik ik this violates DRY, I'm still learning
                        num2 = double.Parse(Console.ReadLine());
                        Calculator.Subtract(num1, num2);
                        Console.WriteLine("Your difference is: " + Calculator.Subtract(num1, num2));
                        break;
                    case "DIVIDE":
                        Messages.InputPrompt();
                        num1 = double.Parse(Console.ReadLine());
                        Messages.InputPrompt();//ik ik this violates DRY, I'm still learning
                        num2 = double.Parse(Console.ReadLine());
                        Calculator.Divide(num1, num2);
                        Console.WriteLine("Your quotient is: " + Calculator.Divide(num1, num2));
                        break;
                    case "MULTIPLY":
                        Messages.InputPrompt();
                        num1 = double.Parse(Console.ReadLine());
                        Messages.InputPrompt();//ik ik this violates DRY, I'm still learning
                        num2 = double.Parse(Console.ReadLine());
                        Calculator.Multiply(num1, num2);
                        Console.WriteLine("Your product is: " + Calculator.Multiply(num1, num2));
                        break;
                }
                Console.Write("\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            }while(redo == 'y' || redo == 'Y');
        }
    }
    static class Messages
    {
        public static void Hello()
        {
            Console.WriteLine("Hello, welcome to my calculator app!");
        }
        public static void Question()
        {
            Console.Write("\n\nWould you like to ADD, SUBTRACT, MULTIPLY, or DIVIDE: ");
        }
        public static void InputPrompt()
        {
            Console.Write("\nPlease enter a number: ");
        }
        public static void GoodBye()
        {
            Console.WriteLine("Goodbye!");
        }
    }
    static class Calculator
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public static double Multiply(double num1, double num2) 
        {
            return num1 * num2;
        }
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}

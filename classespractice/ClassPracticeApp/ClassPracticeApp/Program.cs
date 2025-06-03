namespace ClassPracticeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //class = bundle of related code
            //can be used as a blueprint to create objects
            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();
            
            Console.ReadKey();

        }
    }
   
     
    
}

class Program
{
    static void Main(string[] args)
    {
        Logger l1 = Logger.GetInstance();
        Logger l2 = Logger.GetInstance();

        l1.loggerMessage();
        l2.loggerMessage();


        //Checking the singletons instances
        if (l1 == l2)
        {
            Console.WriteLine("Singleton is working on both instances.");
        }
        else
        {
            Console.WriteLine("Something went wrong!");
        }

        Console.ReadLine();

    }
}
//This is a Logger class
public sealed class Logger
{
    private static Logger Instance = new Logger();
    private Logger() { }
    public static Logger GetInstance()
    {
        if (Instance == null)
        {
            Instance = new Logger();
        }
        return Instance;
    }

    public void loggerMessage()
    {
        Console.WriteLine("Singleton class code has been called!");
        
    }
}
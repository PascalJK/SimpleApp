namespace SimpleApp.Console;

public class ConsoleLogger : ILogger
{
    public void LogErrorMessage(string message)
    {
        System.Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine(message);
    }
    public void LogInfo(string message)
    {
        System.Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine(message);
    }
}

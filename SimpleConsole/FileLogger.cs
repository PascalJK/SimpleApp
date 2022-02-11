namespace SimpleApp.Console;

public class FileLogger : ILogger
{
    private readonly string _path;
    public FileLogger(string path)
    {
        _path = path;
    }

    public void LogErrorMessage(string message) => LogMessageToFile("Error Logged:", message);
    public void LogInfo(string message) => LogMessageToFile("Message Logged:", message);

    private void LogMessageToFile(params string[] message)
    {
        using var streamWriter = new StreamWriter(_path, true);
        System.Console.WriteLine(message);
        streamWriter.WriteLine($"{message[0]} {DateTime.Now}");
        System.Console.WriteLine("Process Complete");
    }
}

namespace SimpleApp.Console;

public interface ILogger
{
    void LogInfo(string message);
    void LogErrorMessage(string message);
}

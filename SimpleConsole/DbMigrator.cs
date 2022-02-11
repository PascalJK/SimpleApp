namespace SimpleApp.Console;

public class DbMigrator
{
    private readonly ILogger logger;

    public DbMigrator(ILogger logger)
    {
        this.logger = logger;
    }

    public void Migrate()
    {
        logger.LogInfo($"Migrating started at: {DateTime.Now}");
        Thread.Sleep(1000);
        logger.LogErrorMessage($"Migrating error detected at: {DateTime.Now}");
        Thread.Sleep(1200);
        logger.LogInfo($"Migrating finished detected at: {DateTime.Now}");
    }
}

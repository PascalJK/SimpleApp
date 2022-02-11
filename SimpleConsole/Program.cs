using SimpleApp.Console;

string path = @"C:\Users\Pascal\Documents\Xamarin Work\SimpleApp\Logger.log";
//var migrator = new DbMigrator(new ConsoleLogger());
var migrator = new DbMigrator(new FileLogger(path));
migrator.Migrate();

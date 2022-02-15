namespace SimpleApp.Console;

public class MailService 
{
    public void OnVideoEncoded(object source, EventArgs args)
    {
        System.Console.WriteLine("MailService: Sent email.....");
    }

    public void OnVideoEncoding(object source, VideoEventArgs args)
    {
        if (args == null)
            throw new ArgumentNullException();

        System.Console.WriteLine($"MailService: Sending {args.Video.Title} email.....");
    }
}

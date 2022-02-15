namespace SimpleApp.Console;

public class MessageService
{
    public void OnVideoEncoded(object source, EventArgs args)
    {
        System.Console.WriteLine("MessageService: Sent Message.....");
    }
    public void OnVideoEncoding(object source, VideoEventArgs args)
    {
        System.Console.WriteLine($"MessageService: Sending { args.Video.Title } Message.....");
    }
}
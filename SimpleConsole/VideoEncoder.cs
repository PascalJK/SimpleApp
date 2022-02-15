namespace SimpleApp.Console;

public class VideoEventArgs : EventArgs
{
    public Video Video { get; set; }
}

public class VideoEncoder
{
    public event EventHandler VideoEncoded;
    public event EventHandler<VideoEventArgs> VideoEncoding;

    public void Encode(Video video)
    {
        System.Console.WriteLine($"Encoding {video.Title} Video...");
        OnViedoEncoding(video);
        Thread.Sleep(5000);
        System.Console.WriteLine("Video Encoding Complete....");
        OnViedoEncoded();
    }
    protected virtual void OnViedoEncoded() => VideoEncoded?.Invoke(this, EventArgs.Empty);
    protected virtual void OnViedoEncoding(Video video) => VideoEncoding?.Invoke(this, new VideoEventArgs() { Video = video});
}

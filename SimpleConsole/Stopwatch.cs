namespace SimpleConsole;

internal class Stopwatch
{
    public DateTime StartTime { get; set; } = DateTime.Now;
    public TimeSpan Duration
    {
        get
        {
            var duration = DateTime.Now.AddSeconds(1) - StartTime;
            var time = Math.Round(duration.TotalSeconds, 2);
            return TimeSpan.FromSeconds(time);
        }
    }

    // Only useful if a setter was set to Duration
    //public TimeSpan Timer() => Duration = DateTime.Now - StartTime;
}

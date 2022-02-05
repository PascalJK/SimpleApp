namespace SimpleConsole;

public class Post
{
    public string Title { get; set; }
    public string Detail { get; set; }
    public DateTime Date { get; set; }
    public int Votes { get;  private set; }

    public Post()
    {
        Votes = 10;
    }

    public void UpVote() => Votes++;
    public void DownVote(int count = 1) => Votes -= count;
}

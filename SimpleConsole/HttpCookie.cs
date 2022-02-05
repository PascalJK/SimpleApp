public class HttpCookie
{
    private readonly Dictionary<string, string> _dictionary = new();

    public string this [string key] 
    {
        get => _dictionary[key];
        set => _dictionary[key] = value;
    }
}
namespace SimpleApp.Console;

public class ExtensionMethod
{
    public string post = "This is my very long blog post. What is lorem ipsum you ask? Well I also dont know.!";
    public ExtensionMethod()
    {
        var shortBlogPost = post.Shorten(5);
        System.Console.WriteLine(shortBlogPost);
    }
}

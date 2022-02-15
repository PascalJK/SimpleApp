namespace SimpleApp.Console;

public static class StringExtensions
{
    public static string Shorten(this string str, int numberOfWords)
    {
        if (numberOfWords < 0)
            throw new ArgumentOutOfRangeException("number of words should be greater than or == to 0...!");

        if (numberOfWords == 0)
            return string.Empty;

        var words = str.Split(' ');

        return words.Length <= numberOfWords ? str : string.Join(" ", words.Take(numberOfWords)) + "...";
    }
}

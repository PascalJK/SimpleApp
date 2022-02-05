namespace SimpleConsole;

internal class Test
{
    public static int Add(params int[] numbers)
    {
        var sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    public static void AddNames(params string[] names)
    {
        int count = 0;
        foreach (var name in names)
        {
            count++;
            Console.WriteLine($"{count}. Username: {name}");
        }
    }
}

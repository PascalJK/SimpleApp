namespace SimpleConsole;

public class Base
{
    public string UiD { get; set; } = Guid.NewGuid().ToString();
    public string Shape { get; set; }

    public Base()
    {
        Console.WriteLine("Base ctor: with no params");
    }
    public Base(string name)
    {
        Console.WriteLine($"Base ctor: Hi my name is {name}");
    }
    public Base(string name, int age)
    {
        Console.WriteLine($"Base ctor: Hi my name is {name}, I'm {age} years old");
    }
}

namespace SimpleConsole;

public abstract class Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Position Position { get; set; }

    // Adding abstract forces design to be followed.
    // If Shape Class is abstract Calling Shape shape = new Shape(); == compile error. => Shape Cannot be instantiated
    public abstract void Draw();
}

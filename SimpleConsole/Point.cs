public class Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Move(Point point)
    {
        Move(point.X, point.Y);
    }
}

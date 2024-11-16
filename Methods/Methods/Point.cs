namespace Methods;

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
        this.X = x;
        this.Y = y;
    }

    // overload Move
    public void Move(Point newLocation)
    {
        // solve this by calling the move method on the newLocation Point Type (which contains x and y)
        // but there's a bug, if this method is null, we will get a null refernce exception, we need to validate that

        if (newLocation == null)
            throw new ArgumentException("newLocation");

        Move(newLocation.X, newLocation.Y);

        // bad practice calling repititoin
        /*this.X = newLocation.X;
        this.Y = newLocation.Y;*/
    }
}

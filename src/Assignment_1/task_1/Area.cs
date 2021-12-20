namespace task_1;

public class Area : Shape
{
    public Area(double length, double width) : base(length, width)
    {
        this.length = length;
        this.width = width;
    }
    
    // return SQUARE area
    public override double area()
    {
        return length * width;
    }

    // return CIRCLE area
    public override double area(double radious)
    {
        return pi * radious * radious;
    }
}
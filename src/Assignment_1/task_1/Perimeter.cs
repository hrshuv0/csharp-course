namespace task_1;

public class Perimeter : Shape
{
    public Perimeter(double length, double width) : base(length, width)
    {
        this.length = length;
        this.width = width;
    }

    // return SQUARE perimeter
    public override double area()
    {
        return 2 * (length + width); // rectangle perimeter
    }

    // return CIRCLE perimeter
    public override double area(double radious)
    {
        return 2 * pi * radious;
    }
}
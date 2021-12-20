namespace task_1;

public abstract class Shape
{
    protected double pi = Math.PI;
    
    public double length { get; set; }
    public double width { get; set; }

    public Shape(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    // return SQUARE
    public abstract double area();
    
    // return CIRCLE
    public abstract double area(double radious);







}
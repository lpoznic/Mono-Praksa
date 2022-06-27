using System;

public class Rectangle : IShape
{
	internal double A { get; set; }
	internal double B { get; set; }

    public Rectangle()
    {
        this.A = 0;
        this.B = 0;
    }

    public Rectangle(int a, int b)
    {
        this.A = a;
        this.B = b;
    }

    public double GetArea()
    {
        return A*B;
    }

    public double GetCircumference()
    {
        return A + B;
    }

    public virtual void PrintShapeInfo()
    {
        Console.WriteLine("First side: " +A +" Second side: "+ B);
        Console.WriteLine("Area: " + GetArea());
        Console.WriteLine("Circumference: " + GetCircumference());
    }
}

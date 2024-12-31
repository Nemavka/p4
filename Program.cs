using System;

public abstract class Figure
{
    public abstract double GetArea();

    public abstract double GetPerimeter();
}

public class Circle: Figure
{
    public double Radius {get; set;}

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Rectangle: Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }

    public override double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
}

public class Rhombus: Figure
{
    public double Diagonal1 { get; set; }
    public double Diagonal2 { get; set; }
    public double Side { get; set; }

    public Rhombus(double diagonal1, double diagonal2, double side)
    {
        Diagonal1 = diagonal1;
        Diagonal2 = diagonal2;
        Side = side;
    }

    public override double GetArea()
    {
        return (Diagonal1 * Diagonal2) / 2;
    }

    public override double GetPerimeter()
    {
        return 4 * Side;
    }
}

public class Program
{
    public static void Main()
    {
        Figure circle = new Circle(5);
        Figure rectangle = new Rectangle(4, 6);
        Figure rhombus = new Rhombus(4, 5, 6);

        Console.WriteLine($"Circle: Area = {circle.GetArea()}, Perimeter = {circle.GetPerimeter()}");
        Console.WriteLine($"Rectangle: Area = {rectangle.GetArea()}, Perimeter = {rectangle.GetPerimeter()}");
        Console.WriteLine($"Rhombus: Area = {rhombus.GetArea()}, Perimeter = {rhombus.GetPerimeter()}");
    }
}

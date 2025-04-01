// Written by Ruth Ayele
// Due 02/27/2025

public abstract class Shape
{
    // Class variable with a get and set
    private string color;
    public string Color
    {
        get { return this.color; }
        set { this.color = value; }
    }

    // Constructor
    public Shape(string color)
    {
        this.color = color;
    }

    // Abstract Method
    public abstract double GetArea();

    // Method
    public override string ToString()
    {
        return $"{this.color} Shape";
    }
}

// Child classes
public class Rectangle : Shape
{
    private double width;
    private double height;

    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public Rectangle(string color, double width, double height) : base(color)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return this.width * this.height;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Width: {this.width}, Height: {this.height}, Area: {GetArea()}";
    }
}

public class Circle : Shape
{
    private double radius;
    public double Radius
    {
        get { return this.radius; }
        set { this.radius = value; }
    }

    public Circle(string color, double radius) : base(color)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * this.radius * this.radius;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Radius: {this.radius}, Area: {GetArea()}"; // recheck
    }
}

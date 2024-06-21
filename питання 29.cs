public abstract class Shape
{
    public abstract double CalculateArea();
}
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

public class Square : Shape
{
    private double sideLength;

    public Square(double sideLength)
    {
        this.sideLength = sideLength;
    }

    public override double CalculateArea()
    {
        return sideLength * sideLength;
    }
}

public class Triangle : Shape
{
    private double baseLength;
    private double height;

    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    public override double CalculateArea()
    {
        return 0.5 * baseLength * height;
    }
}
public interface IDrawable
{
    void Draw();
}
public class Circle : Shape, IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Малюємо коло з радіусом: {0}", radius);
    }
}

public class Square : Shape, IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Малюємо квадрат зі стороною: {0}", sideLength);
    }
}

public class Triangle : Shape, IDrawable
{
    public void Draw()
    {
        Console.WriteLine("Малюємо трикутник з основою: {0} та висотою: {1}", baseLength, height);
    }
}
List<Shape> shapes = new List<Shape>()
{
    new Circle(5),
    new Square(10),
    new Triangle(6, 8)
};

foreach (Shape shape in shapes)
{
    Console.WriteLine("Площа фігури: {0}", shape.CalculateArea());
    shape.Draw();
}

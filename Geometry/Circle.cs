namespace Geometry;
public class Circle : Shape
{
    public double Radius => _a;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius cannot be negative", nameof(radius));
        }
        _a = radius;
    }

    public Circle()
    {
        _a = 1;
    }
}

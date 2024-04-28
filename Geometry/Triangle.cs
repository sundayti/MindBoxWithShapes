namespace Geometry;
public class Triangle : Shape
{
    private double _b;
    private double _c;
    public double A => _a;
    public double B => _b;
    public double C => _c;

    public Triangle(double a, double b, double c)
    {
        if (!IsTriangleExist(a, b, c))
        {
            throw new ArgumentException("This triangle does not exist");
        }

        _a = a;
        _b = b;
        _c = c;
    }

    public Triangle()
    {
        _a = 1;
        _b = 1;
        _c = 1;
    }

    private bool IsTriangleExist(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            return false;
        }

        return a + b > c && a + c > b && b + c > a;
    }

    public bool IsRightTriangle()
    {
        double[] sides = { _a, _b, _c };
        Array.Sort(sides);

        return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) <
               Double.Epsilon;
    }
}

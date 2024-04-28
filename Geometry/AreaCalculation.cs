namespace Geometry;
public class AreaCalculation
{
    public static double GetArea(Shape shape)
    {
        switch (shape.GetType().ToString().Split('.')[1])
        {
            case "Triangle":
                return GetTriangleArea((Triangle)shape); break;
            case "Circle":
                return GetCircleArea((Circle)shape); break;
            default:
                throw new ArgumentException("The library does not have a method for" +
                                            " calculating the area of a given figure");
        }
    }

    public static double GetCircleArea(Circle circle)
    {
        return Math.PI * circle.Radius * circle.Radius;
    }

    public static double GetTriangleArea(Triangle triangle)
    {
        double a = triangle.A;
        double b = triangle.B;
        double c = triangle.C;
        if (!triangle.IsRightTriangle())
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        double[] sides = { a, b, c };
        Array.Sort(sides);

        return sides[0] * sides[1] / 2;
    }
}

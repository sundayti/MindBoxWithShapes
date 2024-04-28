namespace Geometry.Tests;
public class GeometryTests
{
    [Fact]
    public void GetCircleArea_ShouldReturnCorrectArea()
    {
        // Arrange
        double radius = 1;
        Circle circle = new Circle(radius);
        double expectedArea = Math.PI;

        // Act
        double actualArea = AreaCalculation.GetCircleArea(circle);

        // Assert
        Assert.Equal(expectedArea, actualArea, 10); 
    }

    [Fact]
    public void IsRightTriangle_ShouldReturnTrue()
    {
        // Arrange
        Triangle triangle = new Triangle(3, 4, 5);

        // Act
        bool isRightTriangle = triangle.IsRightTriangle();

        // Assert
        Assert.True(isRightTriangle);
    }

    [Fact]
    public void IsRightTriangle_ShouldReturnFalse()
    {
        // Arrange
        Triangle triangle = new Triangle(3, 4, 6);

        // Act
        bool isRightTriangle = triangle.IsRightTriangle();

        // Assert
        Assert.False(isRightTriangle);
    }

    [Fact]
    public void GetTriangleArea_ShouldReturnCorrectArea()
    {
        // Arrange
        Triangle triangle = new Triangle(3, 4, 6);
        double expectedArea = 5.332682251925386;

        // Act
        double actualArea = AreaCalculation.GetTriangleArea(triangle);

        // Assert
        Assert.Equal(expectedArea, actualArea, 10);
    }

    [Fact]
    public void GetTriangleAreaByRightTriangle()
    {
        // Arrange
        Triangle triangle = new Triangle(3, 4, 5);
        double expectedArea = 6;

        // Act
        double actualArea = AreaCalculation.GetTriangleArea(triangle);

        // Assert
        Assert.Equal(expectedArea, actualArea, 10);
    }

    [Fact]
    public void GetAreaByCircle_ShouldReturnCorrectArea()
    {
        // Arrange
        double radius = 1;
        Circle circle = new Circle(radius);
        double expectedArea = Math.PI;

        // Act
        double actualArea = AreaCalculation.GetArea(circle);

        // Assert
        Assert.Equal(expectedArea, actualArea, 10);
    }

    [Fact]
    public void GetAreaByTriangle_ShouldReturnCorrectArea()
    {
        // Arrange
        Triangle triangle = new Triangle(3, 4, 6);
        double expectedArea = 5.332682251925386;

        // Act
        double actualArea = AreaCalculation.GetTriangleArea(triangle);

        // Assert
        Assert.Equal(expectedArea, actualArea, 10);
    }
}

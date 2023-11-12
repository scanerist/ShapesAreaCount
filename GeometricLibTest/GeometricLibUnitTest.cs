using AreaCountOfFigures;
using AreaCountOfFigures.Circles;
using AreaCountOfFigures.ResultTypes;
using AreaCountOfFigures.ValidateShapes;

namespace GeometricLibTest;

using Xunit;

public class GeometricLibUnitTest
{
    [Fact]
    public void CircleAreaCalculation()
    {
        // Arrange
        var circle = new Circle(5);
        var expectedArea = Math.PI * Math.Pow(5, 2);

        // Act
        var actualArea = circle.CountArea();

        // Assert
        Assert.Equal(expectedArea, actualArea, precision: 10);
    }

    [Fact]
    public void TriangleAreaCalculation()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);
        var expectedArea = 6;

        // Act
        var actualArea = triangle.CountArea();

        // Assert
        Assert.Equal(expectedArea, actualArea);
    }

    [Fact]
    public void RightTriangleCheck()
    {
        // Arrange
        var rightTriangle = new Triangle(3, 4, 5);
        var notRightTriangle = new Triangle(1, 2, 3);

        // Act
        var isRightRightTriangle = new ValidateTriangle(rightTriangle).ValidateAngle();
        var isRightNotRightTriangle = new ValidateTriangle(notRightTriangle).ValidateAngle();

        // Assert
        Assert.Equal(isRightRightTriangle, new ResultType.RightAngled());
        Assert.Equal(isRightNotRightTriangle, new ResultType.IncorrectShape());
    }
}
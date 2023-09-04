using Shapes.Exceptions;
using Shapes.Services;
using Xunit;

namespace Shapes.Test;

public class ShapeCircleTests
{
    private readonly ShapeService _shapeService;
    public ShapeCircleTests()
    {
        _shapeService = new ShapeService();
    }
    
    [Theory]
    [InlineData(24, 1810)]
    public void CalculateCircleArea_Success(double radius, double expectedArea)
    {
        // Act
        var area = _shapeService.CalculateCircleArea(radius);

        // Assert
        Assert.Equal(Math.Round(area), expectedArea);
    }
    
    [Theory]
    [InlineData(24, 1800)]
    public void CalculateCircleArea_Wrong(double radius, double expectedArea)
    {
        // Act
        var area = _shapeService.CalculateCircleArea(radius);

        // Assert
        Assert.NotEqual(Math.Round(area), expectedArea);
    }
    
    [Theory]
    [InlineData(0)]
    public void CalculateCircleArea_Error(double radius)
    {
        // Act
        Action action = () => _shapeService.CalculateCircleArea(radius);

        // Assert
        Assert.Throws<ShapeException>(action);
    }
}
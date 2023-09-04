using Shapes.Services;
using Xunit;

namespace Shapes.Test;

public class ShapeTriangleTests
{
    private readonly ShapeService _shapeService;
    public ShapeTriangleTests()
    {
        _shapeService = new ShapeService();
    }
    
    [Theory]
    [InlineData(5, 5, 6, 12)]
    public void CalculateTriangleArea_Success(double sideA, double sideB, double sideC, double expectedArea)
    {
        // Act
        var area = _shapeService.CalculateTriangleArea(sideA, sideB, sideC);

        // Assert
        Assert.Equal(area, expectedArea);
    }
    
    [Theory]
    [InlineData(5, 5, 6, 22)]
    public void CalculateTriangleArea_Wrong(double sideA, double sideB, double sideC, double expectedArea)
    {
        // Act
        var area = _shapeService.CalculateTriangleArea(sideA, sideB, sideC);

        // Assert
        Assert.NotEqual(area, expectedArea);
    }
    
    [Theory]
    [InlineData(24, 5, 6)]
    public void CalculateTriangleArea_Error(double sideA, double sideB, double sideC)
    {
        // Act
        Action action = () => _shapeService.CalculateTriangleArea(sideA, sideB, sideC);

        // Assert
        Assert.Throws<Exception>(action);
    }
    
    [Theory]
    [InlineData(3, 4, 5)]
    public void ValidateTriangleIsRight_Success(double sideA, double sideB, double sideC)
    {
        // Act
        var result = _shapeService.TriangleIsRight(sideA, sideB, sideC);

        // Assert
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(5, 5, 6)]
    public void ValidateTriangleIsRight_Wrong(double sideA, double sideB, double sideC)
    {
        // Act
        var result = _shapeService.TriangleIsRight(sideA, sideB, sideC);

        // Assert
        Assert.False(result);
    }
}
namespace Shapes.Interfaces;

public interface IShapeService
{
    public double CalculateCircleArea(double radius);
    public double CalculateTriangleArea(double sideA, double sideB, double sideC);
    public bool TriangleIsRight(double sideA, double sideB, double sideC);
}
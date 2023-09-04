using Shapes.Interfaces;

namespace Shapes.Models;

public abstract class Shape : IShape
{
    public abstract double CalculateArea();
}
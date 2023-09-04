using Shapes.Exceptions;

namespace Shapes.Models;

/// <summary>
/// Класс круга
/// </summary>
public class Circle : Shape
{
    private double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
        
        ValidateCircle();
    }

    /// <summary>
    /// Вычисляем площадь круга
    /// </summary>
    /// <returns>Площадь</returns>
    public override double CalculateArea()
    {
        return Math.PI * (Radius * Radius);
    }
    
    private void ValidateCircle()
    {
        if (Radius <= 0)
            throw new ShapeException("Радиус не может быть 0");
    }
}
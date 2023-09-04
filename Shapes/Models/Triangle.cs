namespace Shapes.Models;

/// <summary>
/// Класс треугольника
/// </summary>
public class Triangle : Shape
{
    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        
        ValidateTriangle();
    }

    private double SideA { get; }
    private double SideB { get; }
    private double SideC { get; }
    
    /// <summary>
    /// Вычисляем площадь треугольника
    /// </summary>
    /// <returns>Площадь</returns>
    public override double CalculateArea()
    {
        var perimeter  = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC));
    }

    /// <summary>
    /// Проверка, прямоугольный ли треугольник
    /// </summary>
    /// <returns></returns>
    public bool TriangleIsRight()
    {
        if ((SideA * SideA + SideB * SideB == SideC * SideC) || (SideA * SideA + SideC * SideC == SideB * SideB) || (SideC * SideC + SideB * SideB == SideA * SideA))
            return true;
        else
            return false;
    }
    
    private void ValidateTriangle()
    {
        if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
            throw new Exception("Это не треугольник!");
    }
}
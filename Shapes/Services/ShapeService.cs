using Shapes.Interfaces;
using Shapes.Models;

namespace Shapes.Services;

public class ShapeService : IShapeService
{
    /// <summary>
    /// Создаем окружность и вычилсяем ее площадь по радиусу
    /// </summary>
    /// <param name="radius">Радиус</param>
    /// <returns></returns>
    public double CalculateCircleArea(double radius)
    {
        var circle = new Circle(radius);
        return circle.CalculateArea();
    }

    
    /// <summary>
    /// Создаем треугольник и вычисляем его площадь по трем сторонам
    /// </summary>
    /// <param name="sideA">Сторона 1</param>
    /// <param name="sideB">Сторона 2</param>
    /// <param name="sideC">Сторона 3</param>
    /// <returns></returns>
    public double CalculateTriangleArea(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(sideA, sideB, sideC);
        return triangle.CalculateArea();
    }

    /// <summary>
    /// Создаем треугольник и вычисляем, прямоугольный ли он
    /// </summary>
    /// <param name="sideA">Сторона 1</param>
    /// <param name="sideB">Сторона 2</param>
    /// <param name="sideC">Сторона 3</param>
    /// <returns></returns>
    public bool TriangleIsRight(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(sideA, sideB, sideC);
        return triangle.TriangleIsRight();
    }
}
using Shapes.Models;

namespace Shapes.Exceptions;

public class ShapeException : ArgumentException
{
    public ShapeException(string message) : base(message)
    {
        
    }
    
}
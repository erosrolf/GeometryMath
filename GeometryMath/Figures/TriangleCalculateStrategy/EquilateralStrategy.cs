using GeometryMath.Utils;

namespace GeometryMath.Figures.TriangleCalculateStrategy;

public class EquilateralStrategy : ITriangleAreaCalculateStrategy
{
    private readonly double _sideLength;

    public EquilateralStrategy(double sideLength)
    {
        _sideLength = sideLength;
    }
    
    public double CalculateArea()
    {
        return GeometryConstants.Sqrt30Ver4 * _sideLength * _sideLength;
    }
}
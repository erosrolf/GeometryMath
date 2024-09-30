using GeometryMath.Figures;

namespace GeometryMath
{
    public class ShapeFacade
    {
        public double CircleAreaByRadius(double radius)
        {
            var circle = new Circle(radius);
            return circle.Area;
        }
        
        public double TriangleAreaBySides(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            return triangle.Area;
        }

        public bool TriangleIsEquilateral(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            return triangle.IsEquilateral;
        }

        public double CalculateTotalArea(params IShape[] shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.Area;
            }

            return totalArea;
        }
    }
}
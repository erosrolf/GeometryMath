using System;

namespace GeometryMath.Figures
{
    public class Circle : IShape
    {
        private readonly double _radius;
        public double Area => Math.PI * _radius * _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }
        
    }
}
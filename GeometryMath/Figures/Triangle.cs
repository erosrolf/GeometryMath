using System;
using GeometryMath.Figures.TriangleCalculateStrategy;
using GeometryMath.Utils;

namespace GeometryMath.Figures
{
    public class Triangle : IShape
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
        
        public double Area => CalculateArea();
        
        public bool IsEquilateral =>
            DoubleUtils.AreEqualUsingLong(_a, _b, 1e7) 
            && DoubleUtils.AreEqualUsingLong(_b, _c, 1e7);

        public Triangle(double a, double b, double c)
        {
            if (InputValidation(a, b, c) == false)
            {
                throw new ArgumentException($"Triangle is invalid: {a}, {b}, {c}");
            }
            _a = a;
            _b = b;
            _c = c;
        }

        private double CalculateArea()
        {
            ITriangleAreaCalculateStrategy strategy = IsEquilateral
                ? new EquilateralStrategy(_a) : new HeronCalculateStrategy(_a, _b, _c);

            return strategy.CalculateArea();
        }

        private bool InputValidation(double a, double b, double c)
        {
            return !(a + b <= c || a + c <= b || b + c <= a);
        }
    }
}
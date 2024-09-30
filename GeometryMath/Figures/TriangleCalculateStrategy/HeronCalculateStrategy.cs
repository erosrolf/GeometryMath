using System;

namespace GeometryMath.Figures.TriangleCalculateStrategy
{
    public class HeronCalculateStrategy : ITriangleAreaCalculateStrategy
    {
        private readonly double _aSide;
        private readonly double _bSide;
        private readonly double _cSide;

        public HeronCalculateStrategy(double aSide, double bSide, double cSide)
        {
            _aSide = aSide;
            _bSide = bSide;
            _cSide = cSide;
        }
        
        public double CalculateArea()
        {
            double p = (_aSide + _bSide + _cSide) / 2;
            return Math.Sqrt(p * (p - _aSide) * (p - _bSide) * (p - _cSide));   
        }
    }
}
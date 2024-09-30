using System;

namespace GeometryMath.Utils;

public static class DoubleUtils
{
    public static bool AreEqual(double a, double b, double tolerance)
    {
        return Math.Abs(a - b) <= tolerance;
    }

    public static bool AreEqualUsingLong(double a, double b, double tolerance)
    {
        long aLong = (long)(a * 1e7);
        long bLong = (long)(b * 1e7);
        return aLong == bLong;
    }
}
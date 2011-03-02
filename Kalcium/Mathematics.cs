using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalcium
{
    public static class Mathematics
    {
        public static int Sq(this int x)
        {
            return x * x;
        }

        public static double Sq(this double x)
        {
            return x * x;
        }

        public static int ConstrainBetween(this int value, int min, int max)
        {
            return Math.Max(min, Math.Min(max, value));
        }

        public static float ConstrainBetween(this float value, float min, float max)
        {
            return Math.Max(min, Math.Min(max, value));
        }

        public static double ConstrainBetween(this double value, double min, double max)
        {
            return Math.Max(min, Math.Min(max, value));
        }

        public static bool IsWithinRange(this double x, double min, double max)
        {
            return x >= min && x <= max;
        }

        public static double FromRadiansToDegrees(this double x)
        {
            return x * 180 / Math.PI;
        } 

        public static bool IsOdd(this int value)
        {
            return value % 2 == 1;
        }

        public static bool IsEven(this int value)
        {
            return value.IsOdd() == false;
        }
    }
}

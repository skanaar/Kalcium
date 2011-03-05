using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Kalcium
{
    public static class UnitVector
    {
        public static Vector WithAngle(double angle)
        {
            return new Vector(Math.Cos(angle), Math.Sin(angle));
        }
    }
}

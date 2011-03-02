using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Kalcium
{
    public static class RandomVector
    {
        public static Vector WithLength(double length)
        {
            var angle = RandomNumber.Between(0, Math.PI * 2);
            return length * new Vector(Math.Cos(angle), Math.Sin(angle));
        }
    }
}

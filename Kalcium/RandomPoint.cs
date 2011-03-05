using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Kalcium
{
    public static class RandomPoint
    {
        private static Random _rand = new Random();
        public static Point Within(double w, double h)
        {
            return new Point(RandomNumber.Between(0, w), RandomNumber.Between(0, h));
        }
    }
}

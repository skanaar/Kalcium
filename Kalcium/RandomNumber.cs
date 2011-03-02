using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalcium
{
    public static class RandomNumber
    {
        public static Random _random = new Random();

        public static int Between(int min, int max)
        {
            return _random.Next(min, max);
        }

        public static double Between(double min, double max)
        {
            return _random.NextDouble() * (max - min) + min;
        }
    }
}

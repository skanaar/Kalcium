using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Kalcium
{
    public static class VectorOperations
    {
        public static Vector Orthogonal(this Vector me)
        {
            return new Vector(me.Y, -me.X);
        }

        public static Vector Normalized(this Vector me)
        {
            return me / me.Length;
        }
    }
}

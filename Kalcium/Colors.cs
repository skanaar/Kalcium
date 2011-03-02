using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace Kalcium
{
    public static class ColorHelper
    {
        public static Color HsbToRgb(float hue, float saturation, float brightness)
        {
            float red = 0, green = 0, blue = 0;

            if (saturation == 0f)
            {
                red = green = blue = brightness;
            }
            else
            {
                float num = (float)((hue - Math.Floor((double)hue)) * 6.0);
                int num2 = (int)num;
                float num3 = num - num2;
                float num4 = brightness * (1f - saturation);
                float num5 = brightness * (1f - (saturation * num3));
                float num6 = brightness * (1f - (saturation * (1f - num3)));
                switch ((num2 % 6))
                {
                    case 0:
                        red = brightness;
                        green = num6;
                        blue = num4;
                        break;

                    case 1:
                        red = num5;
                        green = brightness;
                        blue = num4;
                        break;

                    case 2:
                        red = num4;
                        green = brightness;
                        blue = num6;
                        break;

                    case 3:
                        red = num4;
                        green = num5;
                        blue = brightness;
                        break;

                    case 4:
                        red = num6;
                        green = num4;
                        blue = brightness;
                        break;

                    case 5:
                        red = brightness;
                        green = num4;
                        blue = num5;
                        break;
                }
            }

            red = red.ConstrainBetween(0, 1);
            green = green.ConstrainBetween(0, 1);
            blue = blue.ConstrainBetween(0, 1);

            return Color.FromScRgb(1, red, green, blue);
        }
    }
}

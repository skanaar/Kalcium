using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalcium
{
    public static class Strings
    {
        public static string Collapse(this IEnumerable<string> me, string separator)
        {
            StringBuilder builder = new StringBuilder();
            bool first = true;
            foreach (string item in me)
            {
                if (!first)
                {
                    builder.Append(separator);
                }
                first = false;
                builder.Append(((Func<string, string>)(str => str))(item));
            }
            return builder.ToString();
        }
    }
}

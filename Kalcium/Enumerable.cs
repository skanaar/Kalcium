using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalcium
{
    public static class Enumerable
    {
        public static bool IsEmpty<TSource>(this IEnumerable<TSource> source)
        {
            if (source is ICollection<TSource>)
            {
                return ((ICollection<TSource>)source).Count == 0;
            }
            else
            {
                using (IEnumerator<TSource> enumerator = source.GetEnumerator())
                {
                    return !enumerator.MoveNext();
                }
            }
        }
    }
}

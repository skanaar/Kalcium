using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalcium
{
    public static class CollectionOperations
    {
        public static void AddRange<T>(this ICollection<T> me, IEnumerable<T> items)
        {
            foreach (var item in items)
                me.Add(item);
        }
    }
}

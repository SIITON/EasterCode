using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterCode
{
    public static class Extensions
    {
        public static bool IsNotPlacedAtUniqueIndex(this IEnumerable<int> sequence)
        {
            return sequence.GroupBy(x => x)
                           .Where(x => x.Count() > 1)
                           .Select(x => x.Key)
                           .Count() >= 1;
        }
    }
}

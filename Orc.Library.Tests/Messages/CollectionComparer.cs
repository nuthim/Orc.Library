using System;
using System.Collections;
using System.Collections.Generic;

namespace Orc.Library.Tests.Messages
{
    public class CollectionComparer : IComparer<ICollection>
    {
        public int Compare(ICollection x, ICollection y)
        {
            if (ReferenceEquals(x, y))
                return 0;

            if (x == null)
                return -1;

            if (y == null)
                return 1;

            if (x.Count != y.Count)
                return x.Count > y.Count ? 1 : -1;

            var a = new ArrayList(x);
            var b = new ArrayList(y);

            for (int i = 0; i < x.Count; i++)
            {
                var equals = new EqualityComparer().Equals(a[i], b[i]);
                if (equals)
                    continue;

                return 1;
            }

            return 0;
        }
    }
}

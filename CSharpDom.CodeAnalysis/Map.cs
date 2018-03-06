using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class Map<TKey, TValue> : Dictionary<TKey, TValue>
    {
        public TKey this[TValue value]
        {
            get { return this.First(entry => Equals(entry.Value, value)).Key; }
        }
    }
}

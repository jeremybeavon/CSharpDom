using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

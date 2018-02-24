using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ReadOnlyCollectionWrapper<T> : IReadOnlyCollection<T>
    {
        private readonly ICollection<T> input;

        public ReadOnlyCollectionWrapper(ICollection<T> input)
        {
            this.input = input;
        }

        public int Count
        {
            get { return input.Count; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return input.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

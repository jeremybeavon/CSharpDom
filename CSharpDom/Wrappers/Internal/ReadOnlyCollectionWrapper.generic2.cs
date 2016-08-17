using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Wrappers.Internal
{
    public class ReadOnlyCollectionWrapper<TInput, TOutput> : IReadOnlyCollection<TOutput>
    {
        private readonly IReadOnlyCollection<TInput> input;
        private readonly Func<TInput, TOutput> converter;

        public ReadOnlyCollectionWrapper(IReadOnlyCollection<TInput> input, Func<TInput, TOutput> converter)
        {
            this.input = input;
            this.converter = converter;
        }

        public int Count
        {
            get { return input.Count; }
        }

        public IEnumerator<TOutput> GetEnumerator()
        {
            return input.Select(converter).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

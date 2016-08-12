using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ReadOnlyListWrapper<TInput, TOutput> : ReadOnlyCollectionWrapper<TInput, TOutput>, IReadOnlyList<TOutput>
    {
        private readonly IReadOnlyList<TInput> input;
        private readonly Func<TInput, TOutput> converter;

        public ReadOnlyListWrapper(IReadOnlyList<TInput> input, Func<TInput, TOutput> converter)
            : base(input, converter)
        {
            this.input = input;
            this.converter = converter;
        }

        public TOutput this[int index]
        {
            get { return converter(input[index]); }
        }

    }
}

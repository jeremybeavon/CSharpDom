using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class ReadOnlyNodeCollection<T, TNode> : IReadOnlyCollection<T>
    {
        private readonly IReadOnlyCollection<TNode> nodes;
        private readonly Func<TNode, T> converter;

        public ReadOnlyNodeCollection(IReadOnlyCollection<TNode> nodes)
            : this(nodes, node => (T)(object)node)
        {
            this.nodes = nodes;
        }

        public ReadOnlyNodeCollection(IReadOnlyCollection<TNode> nodes, Func<TNode, T> converter)
        {
            this.nodes = nodes;
            this.converter = converter;
        }

        public int Count
        {
            get { return nodes.Count; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return nodes.Select(converter).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

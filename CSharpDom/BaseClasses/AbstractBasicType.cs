using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractBasicType<TEvent, TProperty, TIndexer, TMethod> :
        IBasicType<TEvent, TProperty, TIndexer, TMethod>
    {
        public abstract IReadOnlyCollection<TEvent> Events { get; }

        public abstract IReadOnlyCollection<TIndexer> Indexers { get; }

        public abstract IReadOnlyCollection<TMethod> Methods { get; }

        public abstract IReadOnlyCollection<TProperty> Properties { get; }
    }
}

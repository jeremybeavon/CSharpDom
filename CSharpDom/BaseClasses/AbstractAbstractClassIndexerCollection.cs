using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer> :
        AbstractGenericVisitableObject,
        IAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer>
        where TIndexer : IClassIndexer
        where TAbstractIndexer : IAbstractIndexer
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
    {
        public abstract IReadOnlyCollection<TAbstractIndexer> AbstractIndexers { get; }

        public int Count
        {
            get { return Indexers.Count + AbstractIndexers.Count + ExplicitInterfaceIndexers.Count; }
        }

        public abstract IReadOnlyCollection<TExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; }

        protected abstract IReadOnlyCollection<TIndexer> Indexers { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractClassIndexerCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractClassIndexerCollectionChildren(this, visitor);
        }

        public IEnumerator<TIndexer> GetEnumerator()
        {
            return Indexers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> :
        AbstractGenericVisitableObject,
        IClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>
        where TIndexer : IClassIndexer
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
    {
        public int Count
        {
            get { return Indexers.Count + ExplicitInterfaceIndexers.Count; }
        }

        public abstract IReadOnlyCollection<TExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; }

        protected abstract IReadOnlyCollection<TIndexer> Indexers { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassIndexerCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassIndexerCollectionChildren(this, visitor);
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

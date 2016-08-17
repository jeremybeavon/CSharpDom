using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableSealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> :
        ISealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>
        where TIndexer : ISealedClassIndexer
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
    {
        public int Count
        {
            get { return Indexers.Count + ExplicitInterfaceIndexers.Count; }
        }

        public virtual ICollection<TExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }

        public virtual ICollection<TIndexer> Indexers { get; set; }

        IReadOnlyCollection<TExplicitInterfaceIndexer> IHasExplicitInterfaceIndexers<TExplicitInterfaceIndexer>.ExplicitInterfaceIndexers
        {
            get { return new ReadOnlyCollectionWrapper<TExplicitInterfaceIndexer>(ExplicitInterfaceIndexers); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassIndexerCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitSealedClassIndexerCollectionChildren(this, visitor);
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

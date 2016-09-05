using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using System.Collections.ObjectModel;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer> :
        IAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer>
        where TIndexer : IClassIndexer
        where TAbstractIndexer : IAbstractIndexer
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
    {
        public virtual ICollection<TAbstractIndexer> AbstractIndexers { get; set; }

        public int Count
        {
            get { return Indexers.Count + AbstractIndexers.Count + ExplicitInterfaceIndexers.Count; }
        }

        public virtual ICollection<TExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }

        public virtual ICollection<TIndexer> Indexers { get; set; }

        IReadOnlyCollection<TAbstractIndexer> IHasAbstractIndexers<TAbstractIndexer>.AbstractIndexers
        {
            get { return new ReadOnlyCollectionWrapper<TAbstractIndexer>(AbstractIndexers); }
        }

        IReadOnlyCollection<TExplicitInterfaceIndexer> IHasExplicitInterfaceIndexers<TExplicitInterfaceIndexer>.ExplicitInterfaceIndexers
        {
            get { return new ReadOnlyCollectionWrapper<TExplicitInterfaceIndexer>(ExplicitInterfaceIndexers); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractClassIndexerCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
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

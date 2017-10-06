using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer> :
        AbstractGenericVisitableObject,
        IAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer>
        where TIndexer : IClassIndexer
        where TAbstractIndexer : IAbstractIndexer
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
    {
        public abstract ICollection<TAbstractIndexer> AbstractIndexers { get; set; }

        public int Count
        {
            get { return Indexers.Count + AbstractIndexers.Count + ExplicitInterfaceIndexers.Count; }
        }

        public abstract ICollection<TExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }

        public abstract ICollection<TIndexer> Indexers { get; set; }

        IReadOnlyCollection<TAbstractIndexer> IHasAbstractIndexers<TAbstractIndexer>.AbstractIndexers
        {
            get { return new ReadOnlyCollectionWrapper<TAbstractIndexer>(AbstractIndexers); }
        }

        IReadOnlyCollection<TExplicitInterfaceIndexer> IHasExplicitInterfaceIndexers<TExplicitInterfaceIndexer>.ExplicitInterfaceIndexers
        {
            get { return new ReadOnlyCollectionWrapper<TExplicitInterfaceIndexer>(ExplicitInterfaceIndexers); }
        }

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

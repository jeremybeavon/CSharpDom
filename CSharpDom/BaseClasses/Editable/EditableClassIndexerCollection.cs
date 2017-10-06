using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> :
        AbstractGenericVisitableObject,
        IClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>
        where TIndexer : IClassIndexer
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
    {
        public int Count
        {
            get { return Indexers.Count + ExplicitInterfaceIndexers.Count; }
        }

        public abstract ICollection<TExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }

        public abstract ICollection<TIndexer> Indexers { get; set; }

        IReadOnlyCollection<TExplicitInterfaceIndexer> IHasExplicitInterfaceIndexers<TExplicitInterfaceIndexer>.ExplicitInterfaceIndexers
        {
            get { return new ReadOnlyCollectionWrapper<TExplicitInterfaceIndexer>(ExplicitInterfaceIndexers); }
        }

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

using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer> :
        IStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer>
        where TIndexer : IStructIndexer
        where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
    {
        public int Count
        {
            get { return Indexers.Count + ExplicitInterfaceIndexers.Count; }
        }

        public virtual IReadOnlyCollection<TExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }

        protected virtual IReadOnlyCollection<TIndexer> Indexers { get; set; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructIndexerCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructIndexerCollectionChildren(this, visitor);
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

using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> :
        IClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>
        where TIndexer : IClassIndexer
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
            visitor.VisitClassIndexerCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
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

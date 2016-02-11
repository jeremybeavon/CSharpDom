using CSharpDom.Common;
using System.Collections.Generic;
using System.Collections;

namespace CSharpDom.Serialization
{
    public sealed class StructIndexerCollection :
        IStructIndexerCollection<StructIndexer, ExplicitInterfaceIndexer>
    {
        public StructIndexerCollection()
        {
            ExplicitInterfaceIndexers = new List<ExplicitInterfaceIndexer>();
            Indexers = new List<StructIndexer>();
        }

        public int Count
        {
            get { return ExplicitInterfaceIndexers.Count + Indexers.Count; }
        }

        public List<ExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }

        public List<StructIndexer> Indexers { get; set; }
        
        IReadOnlyCollection<ExplicitInterfaceIndexer> IHasExplicitInterfaceIndexers<ExplicitInterfaceIndexer>.ExplicitInterfaceIndexers
        {
            get { return ExplicitInterfaceIndexers; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructIndexerCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructIndexerCollectionChildren(this, visitor);
        }

        public IEnumerator<StructIndexer> GetEnumerator()
        {
            return Indexers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

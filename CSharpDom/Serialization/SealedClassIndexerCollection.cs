using CSharpDom.Common;
using System.Collections.Generic;
using System.Collections;

namespace CSharpDom.Serialization
{
    public sealed class SealedClassIndexerCollection :
        ISealedClassIndexerCollection<SealedClassIndexer, ExplicitInterfaceIndexer>
    {
        public SealedClassIndexerCollection()
        {
            ExplicitInterfaceIndexers = new List<ExplicitInterfaceIndexer>();
            Indexers = new List<SealedClassIndexer>();
        }
        
        public int Count
        {
            get { return ExplicitInterfaceIndexers.Count + Indexers.Count; }
        }

        public List<ExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }

        public List<SealedClassIndexer> Indexers { get; set; }
        
        IReadOnlyCollection<ExplicitInterfaceIndexer> IHasExplicitInterfaceIndexers<ExplicitInterfaceIndexer>.ExplicitInterfaceIndexers
        {
            get { return ExplicitInterfaceIndexers; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassIndexerCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitSealedClassIndexerCollectionChildren(this, visitor);
        }

        public IEnumerator<SealedClassIndexer> GetEnumerator()
        {
            return Indexers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

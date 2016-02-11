using CSharpDom.Common;
using System.Collections.Generic;
using System.Collections;

namespace CSharpDom.Serialization
{
    public sealed class SealedClassIndexerCollection :
        ISealedClassIndexerCollection<SealedClassIndexer, ProtectedOverrideIndexer, ExplicitInterfaceIndexer>
    {
        public SealedClassIndexerCollection()
        {
            ProtectedOverrideIndexers = new List<ProtectedOverrideIndexer>();
            ExplicitInterfaceIndexers = new List<ExplicitInterfaceIndexer>();
            Indexers = new List<SealedClassIndexer>();
        }

        public List<ProtectedOverrideIndexer> ProtectedOverrideIndexers { get; set; }

        public int Count
        {
            get { return ProtectedOverrideIndexers.Count + ExplicitInterfaceIndexers.Count + Indexers.Count; }
        }

        public List<ExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }

        public List<SealedClassIndexer> Indexers { get; set; }

        IReadOnlyCollection<ProtectedOverrideIndexer> IHasProtectedOverrideIndexers<ProtectedOverrideIndexer>.ProtectedOverrideIndexers
        {
            get { return ProtectedOverrideIndexers; }
        }

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

using CSharpDom.Common;
using System.Collections.Generic;
using System.Collections;

namespace CSharpDom.Serialization
{
    public sealed class AbstractClassIndexerCollection :
        IAbstractClassIndexerCollection<ClassIndexer, AbstractIndexer, ExplicitInterfaceIndexer>
    {
        public AbstractClassIndexerCollection()
        {
            AbstractIndexers = new List<AbstractIndexer>();
            ExplicitInterfaceIndexers = new List<ExplicitInterfaceIndexer>();
            Indexers = new List<ClassIndexer>();
        }

        public List<AbstractIndexer> AbstractIndexers { get; set; }

        public int Count
        {
            get { return AbstractIndexers.Count + ExplicitInterfaceIndexers.Count + Indexers.Count; }
        }

        public List<ExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }

        public List<ClassIndexer> Indexers { get; set; }

        IReadOnlyCollection<AbstractIndexer> IHasAbstractIndexers<AbstractIndexer>.AbstractIndexers
        {
            get { return AbstractIndexers; }
        }

        IReadOnlyCollection<ExplicitInterfaceIndexer> IHasExplicitInterfaceIndexers<ExplicitInterfaceIndexer>.ExplicitInterfaceIndexers
        {
            get { return ExplicitInterfaceIndexers; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAbstractClassIndexerCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAbstractClassIndexerCollectionChildren(this, visitor);
        }

        public IEnumerator<ClassIndexer> GetEnumerator()
        {
            return Indexers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

using CSharpDom.Common;
using System.Collections.Generic;
using System.Collections;

namespace CSharpDom.Serialization
{
    public sealed class ClassIndexerCollection :
        IClassIndexerCollection<ClassIndexer, ExplicitInterfaceIndexer>
    {
        public ClassIndexerCollection()
        {
            ExplicitInterfaceIndexers = new List<ExplicitInterfaceIndexer>();
            Indexers = new List<ClassIndexer>();
        }

        public int Count
        {
            get { return ExplicitInterfaceIndexers.Count + Indexers.Count; }
        }

        public List<ExplicitInterfaceIndexer> ExplicitInterfaceIndexers { get; set; }

        public List<ClassIndexer> Indexers { get; set; }
        
        IReadOnlyCollection<ExplicitInterfaceIndexer> IHasExplicitInterfaceIndexers<ExplicitInterfaceIndexer>.ExplicitInterfaceIndexers
        {
            get { return ExplicitInterfaceIndexers; }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassIndexerCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassIndexerCollectionChildren(this, visitor);
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

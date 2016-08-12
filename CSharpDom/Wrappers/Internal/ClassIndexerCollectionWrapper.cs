using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class ClassIndexerCollectionWrapper :
        AbstractWrapper<IClassIndexerCollection>
    {
        public ClassIndexerCollectionWrapper(IClassIndexerCollection indexerCollection)
            : base(indexerCollection)
        {
        }

        public override void VisitClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            IClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
            Value = new ClassIndexerCollection()
            {
                Indexers = indexerCollection.ToList(indexer => new ClassIndexerWrapper(indexer).Value),
                ExplicitInterfaceIndexers = indexerCollection.ExplicitInterfaceIndexers.ToList(indexer => new ExplicitInterfaceIndexerWrapper(indexer).Value)
            };
        }
    }
}

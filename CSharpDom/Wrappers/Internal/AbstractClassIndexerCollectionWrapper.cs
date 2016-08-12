using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class AbstractClassIndexerCollectionWrapper :
        AbstractWrapper<IAbstractClassIndexerCollection>
    {
        public AbstractClassIndexerCollectionWrapper(IAbstractClassIndexerCollection indexerCollection)
            : base(indexerCollection)
        {
        }

        public override void VisitAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer>(
            IAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
            Value = new AbstractClassIndexerCollection()
            {
                Indexers = indexerCollection.ToList(indexer => new ClassIndexerWrapper(indexer).Value),
                AbstractIndexers = indexerCollection.AbstractIndexers.ToList(indexer => new AbstractIndexerWrapper(indexer).Value),
                ExplicitInterfaceIndexers = indexerCollection.ExplicitInterfaceIndexers.ToList(indexer => new ExplicitInterfaceIndexerWrapper(indexer).Value)
            };
        }
    }
}

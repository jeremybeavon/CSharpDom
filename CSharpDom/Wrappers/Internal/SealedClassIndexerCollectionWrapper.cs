using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class SealedClassIndexerCollectionWrapper :
        AbstractWrapper<ISealedClassIndexerCollection>
    {
        public SealedClassIndexerCollectionWrapper(ISealedClassIndexerCollection indexerCollection)
            : base(indexerCollection)
        {
        }

        public override void VisitSealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            ISealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
            Value = new SealedClassIndexerCollection()
            {
                Indexers = indexerCollection.ToList(indexer => new SealedClassIndexerWrapper(indexer).Value),
                ExplicitInterfaceIndexers = indexerCollection.ExplicitInterfaceIndexers.ToList(indexer => new ExplicitInterfaceIndexerWrapper(indexer).Value)
            };
        }
    }
}

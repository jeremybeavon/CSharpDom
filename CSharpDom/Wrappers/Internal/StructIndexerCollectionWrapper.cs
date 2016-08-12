using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    public class StructIndexerCollectionWrapper :
        AbstractWrapper<IStructIndexerCollection>
    {
        public StructIndexerCollectionWrapper(IStructIndexerCollection indexerCollection)
            : base(indexerCollection)
        {
        }

        public override void VisitStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            IStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
            Value = new StructIndexerCollection()
            {
                Indexers = indexerCollection.ToList(indexer => new StructIndexerWrapper(indexer).Value),
                ExplicitInterfaceIndexers = indexerCollection.ExplicitInterfaceIndexers.ToList(indexer => new ExplicitInterfaceIndexerWrapper(indexer).Value)
            };
        }
    }
}

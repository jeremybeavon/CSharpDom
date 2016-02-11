using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class StructIndexerCollectionFactory :
        AbstractFactory<IStructIndexerCollection, StructIndexerCollection>
    {
        public StructIndexerCollectionFactory(IStructIndexerCollection indexerCollection)
            : base(indexerCollection)
        {
        }

        public override void VisitStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            IStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
            Value = new StructIndexerCollection()
            {
                Indexers = indexerCollection.ToList(indexer => new StructIndexerFactory(indexer).Value),
                ExplicitInterfaceIndexers = indexerCollection.ExplicitInterfaceIndexers.ToList(indexer => new ExplicitInterfaceIndexerFactory(indexer).Value)
            };
        }
    }
}

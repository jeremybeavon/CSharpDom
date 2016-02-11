using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class SealedClassIndexerCollectionFactory :
        AbstractFactory<ISealedClassIndexerCollection, SealedClassIndexerCollection>
    {
        public SealedClassIndexerCollectionFactory(ISealedClassIndexerCollection indexerCollection)
            : base(indexerCollection)
        {
        }

        public override void VisitSealedClassIndexerCollection<TIndexer, TProtectedOverrideIndexer, TExplicitInterfaceIndexer>(
            ISealedClassIndexerCollection<TIndexer, TProtectedOverrideIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
            Value = new SealedClassIndexerCollection()
            {
                Indexers = indexerCollection.ToList(indexer => new SealedClassIndexerFactory(indexer).Value),
                ProtectedOverrideIndexers = indexerCollection.ProtectedOverrideIndexers.ToList(indexer => new ProtectedOverrideIndexerFactory(indexer).Value),
                ExplicitInterfaceIndexers = indexerCollection.ExplicitInterfaceIndexers.ToList(indexer => new ExplicitInterfaceIndexerFactory(indexer).Value)
            };
        }
    }
}

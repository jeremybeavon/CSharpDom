using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class AbstractClassIndexerCollectionFactory :
        AbstractFactory<IAbstractClassIndexerCollection, AbstractClassIndexerCollection>
    {
        public AbstractClassIndexerCollectionFactory(IAbstractClassIndexerCollection indexerCollection)
            : base(indexerCollection)
        {
        }

        public override void VisitAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer>(
            IAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
            Value = new AbstractClassIndexerCollection()
            {
                Indexers = indexerCollection.ToList(indexer => new ClassIndexerFactory(indexer).Value),
                AbstractIndexers = indexerCollection.AbstractIndexers.ToList(indexer => new AbstractIndexerFactory(indexer).Value),
                ExplicitInterfaceIndexers = indexerCollection.ExplicitInterfaceIndexers.ToList(indexer => new ExplicitInterfaceIndexerFactory(indexer).Value)
            };
        }
    }
}

using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public class ClassIndexerCollectionFactory :
        AbstractFactory<IClassIndexerCollection, ClassIndexerCollection>
    {
        public ClassIndexerCollectionFactory(IClassIndexerCollection indexerCollection)
            : base(indexerCollection)
        {
        }

        public override void VisitClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            IClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
        {
            Value = new ClassIndexerCollection()
            {
                Indexers = indexerCollection.ToList(indexer => new ClassIndexerFactory(indexer).Value),
                ExplicitInterfaceIndexers = indexerCollection.ExplicitInterfaceIndexers.ToList(indexer => new ExplicitInterfaceIndexerFactory(indexer).Value)
            };
        }
    }
}

using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class IndexerFactory : AbstractFactory<IIndexer, Indexer>
    {
        public IndexerFactory(IIndexer indexer)
            : base(indexer)
        {
        }

        public override void VisitIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Value = new Indexer()
            {
                Attributes = indexer.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new AccessorFactory(indexer.GetAccessor).Value,
                IndexerType = new TypeReferenceFactory(indexer.IndexerType).Value,
                InheritanceModifier = indexer.InheritanceModifier,
                Parameters = indexer.Parameters.ToParameterListUsingFactory(),
                SetAccessor = new AccessorFactory(indexer.SetAccessor).Value,
                Visibility = indexer.Visibility
            };
        }
    }
}

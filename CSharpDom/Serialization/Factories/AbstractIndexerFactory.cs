using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class AbstractIndexerFactory : AbstractFactory<IAbstractIndexer, AbstractIndexer>
    {
        public AbstractIndexerFactory(IAbstractIndexer indexer)
            : base(indexer)
        {
        }

        public override void VisitAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Value = new AbstractIndexer()
            {
                Attributes = indexer.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new AbstractAccessorFactory(indexer.GetAccessor).Value,
                IndexerType = new TypeReferenceFactory(indexer.IndexerType).Value,
                Parameters = indexer.Parameters.ToParameterListUsingFactory(),
                SetAccessor = new AbstractAccessorFactory(indexer.SetAccessor).Value
            };
        }
    }
}

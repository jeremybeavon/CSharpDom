using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class ExplicitInterfaceIndexerFactory : AbstractFactory<IExplicitInterfaceIndexer, ExplicitInterfaceIndexer>
    {
        public ExplicitInterfaceIndexerFactory(IExplicitInterfaceIndexer indexer)
            : base(indexer)
        {
        }

        public override void VisitExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor>(
            IExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor> indexer)
        {
            Value = new ExplicitInterfaceIndexer()
            {
                Attributes = indexer.Attributes.ToAttributeListUsingFactory(),
                IndexerType = new TypeReferenceFactory(indexer.IndexerType).Value,
                Parameters = indexer.Parameters.ToParameterListUsingFactory()
            };
        }
    }
}

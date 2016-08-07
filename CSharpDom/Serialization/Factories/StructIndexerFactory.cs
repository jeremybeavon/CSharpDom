using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class StructIndexerFactory : AbstractFactory<IStructIndexer, StructIndexer>
    {
        public StructIndexerFactory(IStructIndexer indexer)
            : base(indexer)
        {
        }

        public override void VisitStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Value = new StructIndexer()
            {
                Attributes = indexer.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new StructAccessorFactory(indexer.GetAccessor).Value,
                IndexerType = new TypeReferenceFactory(indexer.IndexerType).Value,
                Parameters = indexer.Parameters.ToList(parameter => new IndexerParameterFactory(parameter).Value),
                SetAccessor = new StructAccessorFactory(indexer.SetAccessor).Value,
                Visibility = indexer.Visibility
            };
        }
    }
}

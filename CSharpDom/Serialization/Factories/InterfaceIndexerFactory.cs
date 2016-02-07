using CSharpDom.Common;

namespace CSharpDom.Serialization.Factories
{
    public sealed class InterfaceIndexerFactory : AbstractFactory<IInterfaceIndexer, InterfaceIndexer>
    {
        public InterfaceIndexerFactory(IInterfaceIndexer indexer)
            : base(indexer)
        {
        }

        public override void VisitInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Value = new InterfaceIndexer()
            {
                Attributes = indexer.Attributes.ToAttributeListUsingFactory(),
                GetAccessor = new InterfaceAccessorFactory(indexer.GetAccessor).Value,
                IndexerType = new TypeReferenceFactory(indexer.IndexerType).Value,
                InheritanceModifier = indexer.InheritanceModifier,
                Parameters = indexer.Parameters.ToParameterListUsingFactory(),
                SetAccessor = new InterfaceAccessorFactory(indexer.SetAccessor).Value
            };
        }
    }
}

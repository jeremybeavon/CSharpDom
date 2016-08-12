using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class InterfaceIndexerWrapper : AbstractWrapper<IInterfaceIndexer>
    {
        public InterfaceIndexerWrapper(IInterfaceIndexer indexer)
            : base(indexer)
        {
        }

        public override void VisitInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Value = new InterfaceIndexer()
            {
                Attributes = indexer.Attributes.ToAttributeListUsingWrapper(),
                GetAccessor = new InterfaceAccessorWrapper(indexer.GetAccessor).Value,
                IndexerType = new TypeReferenceWrapper(indexer.IndexerType).Value,
                InheritanceModifier = indexer.InheritanceModifier,
                Parameters = indexer.Parameters.ToList(parameter => new IndexerParameterWrapper(parameter).Value),
                SetAccessor = new InterfaceAccessorWrapper(indexer.SetAccessor).Value
            };
        }
    }
}

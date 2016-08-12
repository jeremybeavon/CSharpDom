using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ExplicitInterfaceIndexerWrapper : AbstractWrapper<IExplicitInterfaceIndexer>
    {
        public ExplicitInterfaceIndexerWrapper(IExplicitInterfaceIndexer indexer)
            : base(indexer)
        {
        }

        public override void VisitExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor>(
            IExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor> indexer)
        {
            Value = new ExplicitInterfaceIndexer()
            {
                Attributes = indexer.Attributes.ToAttributeListUsingWrapper(),
                ExplicitInterface = new InterfaceReferenceWrapper(indexer.ExplicitInterface).Value,
                GetAccessor = new AccessorWrapper(indexer.GetAccessor).Value,
                IndexerType = new TypeReferenceWrapper(indexer.IndexerType).Value,
                Parameters = indexer.Parameters.ToList(parameter => new IndexerParameterWrapper(parameter).Value),
                SetAccessor = new AccessorWrapper(indexer.SetAccessor).Value
            };
        }
    }
}

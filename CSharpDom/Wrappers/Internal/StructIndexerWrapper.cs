using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructIndexerWrapper : AbstractWrapper<IStructIndexer>
    {
        public StructIndexerWrapper(IStructIndexer indexer)
            : base(indexer)
        {
        }

        public override void VisitStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Value = new StructIndexer()
            {
                Attributes = indexer.Attributes.ToAttributeListUsingWrapper(),
                GetAccessor = new StructAccessorWrapper(indexer.GetAccessor).Value,
                IndexerType = new TypeReferenceWrapper(indexer.IndexerType).Value,
                Parameters = indexer.Parameters.ToList(parameter => new IndexerParameterWrapper(parameter).Value),
                SetAccessor = new StructAccessorWrapper(indexer.SetAccessor).Value,
                Visibility = indexer.Visibility
            };
        }
    }
}

using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class AbstractIndexerWrapper : AbstractWrapper<IAbstractIndexer>
    {
        public AbstractIndexerWrapper(IAbstractIndexer indexer)
            : base(indexer)
        {
        }

        public override void VisitAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Value = new AbstractIndexer()
            {
                Attributes = indexer.Attributes.ToAttributeListUsingWrapper(),
                GetAccessor = new AbstractAccessorWrapper(indexer.GetAccessor).Value,
                IndexerType = new TypeReferenceWrapper(indexer.IndexerType).Value,
                Parameters = indexer.Parameters.ToList(parameter => new IndexerParameterWrapper(parameter).Value),
                SetAccessor = new AbstractAccessorWrapper(indexer.SetAccessor).Value
            };
        }
    }
}

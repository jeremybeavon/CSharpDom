using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassIndexerWrapper : AbstractWrapper<IClassIndexer>
    {
        public ClassIndexerWrapper(IClassIndexer indexer)
            : base(indexer)
        {
        }

        public override void VisitClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Value = new ClassIndexer()
            {
                Attributes = indexer.Attributes.ToAttributeListUsingWrapper(),
                GetAccessor = new ClassAccessorWrapper(indexer.GetAccessor).Value,
                IndexerType = new TypeReferenceWrapper(indexer.IndexerType).Value,
                InheritanceModifier = indexer.InheritanceModifier,
                Parameters = indexer.Parameters.ToList(parameter => new IndexerParameterWrapper(parameter).Value),
                SetAccessor = new ClassAccessorWrapper(indexer.SetAccessor).Value,
                Visibility = indexer.Visibility
            };
        }
    }
}

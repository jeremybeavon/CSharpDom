using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class SealedClassIndexerWrapper : AbstractWrapper<ISealedClassIndexer>
    {
        public SealedClassIndexerWrapper(ISealedClassIndexer indexer)
            : base(indexer)
        {
        }

        public override void VisitSealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            ISealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            Value = new SealedClassIndexer()
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
